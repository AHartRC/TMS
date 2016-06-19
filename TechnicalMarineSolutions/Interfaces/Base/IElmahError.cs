namespace TechnicalMarineSolutions.Interfaces.Base
{
	#region Library Imports

	using System;

	#endregion

	public interface IElmahError
	{
		Guid ErrorId
		{
			get;
			set;
		}

		string Application
		{
			get;
			set;
		}

		string Host
		{
			get;
			set;
		}

		string Type
		{
			get;
			set;
		}

		string Source
		{
			get;
			set;
		}

		string Message
		{
			get;
			set;
		}

		string User
		{
			get;
			set;
		}

		int StatusCode
		{
			get;
			set;
		}

		DateTime TimeUtc
		{
			get;
			set;
		}

		int Sequence
		{
			get;
			set;
		}

		string AllXml
		{
			get;
			set;
		}
	}
}