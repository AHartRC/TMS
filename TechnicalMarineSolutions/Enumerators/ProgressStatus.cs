namespace TechnicalMarineSolutions.Enumerators
{
	#region Library Imports

	using System;

	#endregion

	[Flags]
	public enum ProgressStatus
	{
		Unknown = 0,
		Visible = 1,
		Hidden = 2,
		Deleted = 4,
		Archived = 8,
		Locked = 16,
		Valid = 32,
		Invalid = 64,
		Pending = 128,
		Scheduled = 256,
		OnHold = 512,
		Accepted = 1024,
		Rejected = 2048,
		Cancelled = 4096,
		Permitted = 8192,
		Forbidden = 16384,
		Featured = 32768,
		Preferred = 65536,
		Promotional = 131072,
		Elite = 262144,
		Current = 524288,
		Outdated = 1048576,
		New = 2097152,
		Old = 4194304,
		Spam = 8388608,
		Malicious = 1677216,
		Unsolicited = 33554432
	}
}