namespace TechnicalMarineSolutions.Interfaces.Base
{
	using TechnicalMarineSolutions.Enumerators;

	public interface IStreetAddress
	{
		/// <summary>
		///     The Type of Address
		/// </summary>
		PostalAddressType AddressType
		{
			get;
			set;
		}

		/// <summary>
		///     The Number and Street of the location
		/// </summary>
		string Address1
		{
			get;
			set;
		}

		/// <summary>
		///     Additional information such as Apartment or Suite number
		/// </summary>
		string Address2
		{
			get;
			set;
		}

		/// <summary>
		///     The City of which the location is in
		/// </summary>
		string City
		{
			get;
			set;
		}

		/// <summary>
		///     The State of which the location is in
		/// </summary>
		string State
		{
			get;
			set;
		}

		/// <summary>
		///     The Postal Code for the location
		/// </summary>
		string PostalCode
		{
			get;
			set;
		}
	}
}