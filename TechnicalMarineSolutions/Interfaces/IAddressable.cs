#region Library Imports

using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface IAddressable
	{
		long AddressId
		{
			get;
			set;
		}

		PostalAddress Address
		{
			get;
			set;
		}
	}
}