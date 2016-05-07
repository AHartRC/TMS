#region Library Imports

using System;

#endregion

namespace TechnicalMarineSolutions.Enumerators
{
	[Flags]
	public enum PostalAddressType
	{
		Unknown = 0,
		Home = 1,
		Business = 2,
		Billing = 4,
		Mailing = 8,
		Shipping = 16
	}
}