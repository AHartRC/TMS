#region Library Imports

using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface IHomeable
	{
		long? HomeAddressId
		{
			get;
			set;
		}

		PostalAddress HomeAddress
		{
			get;
			set;
		}
	}
}