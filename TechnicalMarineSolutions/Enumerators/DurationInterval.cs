namespace TechnicalMarineSolutions.Enumerators
{
	#region Library Imports

	using System;

	#endregion

	[Flags]
	public enum DurationInterval
	{
		Once = 0,
		Nanosecond = 1,
		Millisecond = 2,
		Second = 4,
		Minute = 8,
		Hour = 16,
		Day = 32,
		WorkWeek = 64,
		FullWeek = 128,
		BiWeekly = 256,
		SemiMonthly = 512,
		Monthly = 1024,
		SemiQuarterly = 2048,
		Quarterly = 4096,
		SemiAnnually = 8192,
		Annually = 16384,
		BiAnnually = 32768,
		Custom = 65536
	}
}