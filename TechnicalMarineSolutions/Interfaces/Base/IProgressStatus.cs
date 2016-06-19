namespace TechnicalMarineSolutions.Interfaces.Base
{
	#region Library Imports

	using TechnicalMarineSolutions.Enumerators;

	#endregion

	public interface IProgressStatus
	{
		/// <summary>
		///     The Progress Status of the event
		///     <para>This is to indicate how far along the event is</para>
		/// </summary>
		ProgressStatus ProgressStatus
		{
			get;
			set;
		}
	}
}