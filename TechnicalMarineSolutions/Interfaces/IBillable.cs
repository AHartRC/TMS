#region Library Imports

using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface IBillable
	{
		long? BillingAddressId
		{
			get;
			set;
		}

		PostalAddress BillingAddress
		{
			get;
			set;
		}
	}
}