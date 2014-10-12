using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace AckSharp
{
	public static class LiteC
	{
		// Needed to keep pointers "alive"
		readonly static HashSet<Delegate> cache = new HashSet<Delegate>();

		/// <summary>
		/// Gets a native pointer for delegate.
		/// </summary>
		/// <param name="@delegate"></param>
		/// <returns></returns>
		public static IntPtr GetMethodPointer(Delegate @delegate)
		{
			IntPtr ptr = Marshal.GetFunctionPointerForDelegate(@delegate);
			cache.Add(@delegate); // Keep the delegate alive.
			return ptr;
		}

		/// <summary>
		/// Gets a delegate to a script function.
		/// </summary>
		/// <param name="functionName"></param>
		/// <remarks>engine_getscript</remarks>
		/// <returns></returns>
		public static Delegate GetFunction<T>(string functionName)
		{
			if (!typeof(T).IsSubclassOf(typeof(Delegate)))
			{
				throw new InvalidOperationException(typeof(T).Name + " is not a delegate type");
			}

			IntPtr fnPtr = Native.NativeMethods.EngineGetScript(functionName);
			if (fnPtr == IntPtr.Zero)
				return null;

			return Marshal.GetDelegateForFunctionPointer(fnPtr, typeof(T));
		}

		/// <summary>
		/// Gets a function pointer to a script function.
		/// </summary>
		/// <param name="functionName"></param>
		/// <remarks>engine_getscript</remarks>
		/// <returns></returns>
		public static IntPtr GetFunction(string functionName)
		{
			return Native.NativeMethods.EngineGetScript(functionName);
		}

		/// <summary>
		/// Gets the name of a LiteC script function.
		/// </summary>
		/// <param name="function"></param>
		/// <remarks>engine_getscriptinfo</remarks>
		/// <returns></returns>
		public static string GetFunctionName(IntPtr function)
		{
			IntPtr namePtr;
			if (Native.NativeMethods.EngineGetScriptInfo(function, out namePtr) != function)
			{
				return null;
			}
			if (namePtr == IntPtr.Zero)
			{
				return null;
			}
			return Marshal.PtrToStringAnsi(namePtr);
		}

		/// <summary>
		/// Returns the name, me pointer, and address of a currently running lite-C script function instance (task).
		/// Can be used to generate a list of all currently running functions, for debugging or similar purposes. 
		/// </summary>
		/// <param name="num">number of the task, starting with 0.</param>
		/// <returns>Task or null when num exceeds the number of currently running functions.</returns>
		/// <remarks>engine_gettaskinfo</remarks>
		public static Task GetTaskInfo(int num)
		{
			IntPtr namePtr;
			IntPtr entityPtr;
			IntPtr methodPtr = Native.NativeMethods.EngineGetTaskInfo(num, out namePtr, out entityPtr);
			if (methodPtr == IntPtr.Zero)
				return null;
			Task task = new Task();
			task.Function = methodPtr;
			if (namePtr != IntPtr.Zero)
				task.FunctionName = Marshal.PtrToStringAnsi(namePtr);
			else
				task.FunctionName = LiteC.GetFunctionName(methodPtr);
			task.Me = EngineObject.Get<Entity>(entityPtr);
			return task;
		}

		/// <summary>
		/// Gets an enumeration of all running tasks.
		/// </summary>
		/// <remarks>engine_gettaskinfo</remarks>
		/// <returns></returns>
		public static IEnumerable<Task> GetTasks()
		{
			for (int i = 0; ; i++)
			{
				var t = GetTaskInfo(i);
				if (t == null)
					yield break;
				else
					yield return t;
			}
		}
	}

	public sealed class Task
	{
		public string Name { get; internal set; }
		public IntPtr Function { get; internal set; }
		public string FunctionName { get; internal set; }

		public Entity Me { get; internal set; }
	}
}
