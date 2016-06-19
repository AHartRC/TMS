namespace TechnicalMarineSolutions.Interfaces.Base
{
	#region Library Imports

	using TechnicalMarineSolutions.Enumerators;

	#endregion

	public interface IRecordStatus
	{
		/// <summary>
		///     The Current status of the Record
		///     <para>This is to be used for internal purposes</para>
		///     This field will be utilized for flagging records as spam/archived/deleted/featured/etc
		/// </summary>
		RecordStatus RecordStatus
		{
			get;
			set;
		}
	}
}