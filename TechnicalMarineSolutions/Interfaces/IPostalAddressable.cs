#region Library Imports

using TechnicalMarineSolutions.Enumerators;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface IPostalAddressable
	{
		PostalAddressType AddressType
		{
			get;
			set;
		}

		string Recipient
		{
			get;
			set;
		}

		string Attention
		{
			get;
			set;
		}

		string Address1
		{
			get;
			set;
		}

		string Address2
		{
			get;
			set;
		}

		string City
		{
			get;
			set;
		}

		string State
		{
			get;
			set;
		}

		string Zip
		{
			get;
			set;
		}
	}
}