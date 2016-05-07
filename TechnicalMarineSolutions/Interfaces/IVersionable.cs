namespace TechnicalMarineSolutions.Interfaces
{
	public interface IVersionable
	{
		int? MajorVersion
		{
			get;
			set;
		}

		int? MajorVersionRevision
		{
			get;
			set;
		}

		int? MinorVersion
		{
			get;
			set;
		}

		int? MinorVersionRevision
		{
			get;
			set;
		}

		int? Revision
		{
			get;
			set;
		}

		long? BuildNumber
		{
			get;
			set;
		}
	}
}