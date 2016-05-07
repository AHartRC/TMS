#region Library Imports

using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface IShippable
	{
		long? ShippingAddressId
		{
			get;
			set;
		}

		PostalAddress ShippingAddress
		{
			get;
			set;
		}
	}
}