namespace TechnicalMarineSolutions.Interfaces.Base
{
	#region Library Imports

	using TechnicalMarineSolutions.Enumerators;

	#endregion

	public interface IRetailItem
	{
		/// <summary>
		///     The Universal Product Code that corresponds to the item
		/// </summary>
		string UPC
		{
			get;
			set;
		}

		/// <summary>
		///     A unique identifier typically assigned by a third party
		/// </summary>
		string PartNumber
		{
			get;
			set;
		}

		/// <summary>
		///     The type of packaging that the item is sold in
		/// </summary>
		PackageType PackageType
		{
			get;
			set;
		}

		/// <summary>
		///     The current condition of the item
		/// </summary>
		ItemCondition Condtion
		{
			get;
			set;
		}
	}
}