namespace AckNET
{
	public enum CollisionFlags
	{
		None = 0,
		IgnoreMe = (1 << 0),
		IgnoreYou = (1 << 1),
		IgnorePassable = (1 << 2),
		IgnorePassents = (1 << 3),
		IgnoreModels = (1 << 4),
		IgnoreSprites = (1 << 5),
		IgnoreContent = (1 << 6),
		IgnoreMaps = (1 << 7),
		IgnoreWorld = (1 << 8),
		IgnorePush = (1 << 9),
		ActivateShoot = (1 << 10),
		ActivateSonar = (1 << 11),
		ActivateTrigger = (1 << 12),
		UseBox = (1 << 13),
		GetHitVertex = (1 << 14),
		ActivatePush = (1 << 14),
		UseAxis = (1 << 15),
		UseAxisR = (1 << 16),
		ScanTexture = (1 << 16),
		UseAabb = (1 << 17),
		Glide = (1 << 18),
		UsePolygon = (1 << 19),
		IgnoreFlag2 = (1 << 21),
	}
}