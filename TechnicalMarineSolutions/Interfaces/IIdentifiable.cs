namespace TechnicalMarineSolutions.Interfaces
{
	public interface IIdentifiable
	{
		/// <summary>
		///     The Identification value of this record
		/// </summary>
		long Id
		{
			get;
			set;
		}
	}
}