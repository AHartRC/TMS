#region Library Imports

using TechnicalMarineSolutions.Enumerators;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface IStatusable
	{
		/// <summary>
		///     The status(es) of the record
		/// </summary>
		RecordStatus Status
		{
			get;
			set;
		}
	}
}