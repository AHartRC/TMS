namespace TechnicalMarineSolutions.Interfaces.Base
{
	public interface INote
	{
		/// <summary>
		///     Notes that are available to the public
		/// </summary>
		string PublicNotes
		{
			get;
			set;
		}

		/// <summary>
		///     Notes that are available to administrators and moderators only
		/// </summary>
		string PrivateNotes
		{
			get;
			set;
		}
	}
}