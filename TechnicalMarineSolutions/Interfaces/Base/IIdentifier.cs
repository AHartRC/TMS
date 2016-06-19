namespace TechnicalMarineSolutions.Interfaces.Base
{
	public interface IIdentifier
	{
		/// <summary>
		///     The Primary Identifier of the record. This is typically the primary key column.
		/// </summary>
		long Id
		{
			get;
			set;
		}
	}
}