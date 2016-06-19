namespace TechnicalMarineSolutions.Enumerators
{
	#region Library Imports

	using System;

	#endregion

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