#region Library Imports

using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface IMailable
	{
		long? MailingAddressId
		{
			get;
			set;
		}

		PostalAddress MailingAddress
		{
			get;
			set;
		}
	}
}