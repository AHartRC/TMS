namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	#region Library Imports

	#endregion

	public interface IPostalAddressable
	{
		/// <summary>
		///     The ID of the <see cref="Address" /> Record
		/// </summary>
		long AddressId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.PostalAddress" /> Record
		/// </summary>
		PostalAddress Address
		{
			get;
			set;
		}
	}
}