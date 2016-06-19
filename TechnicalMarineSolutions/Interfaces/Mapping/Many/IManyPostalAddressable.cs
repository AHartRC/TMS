namespace TechnicalMarineSolutions.Interfaces.Mapping.Many
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	#region Library Imports

	#endregion

	public interface IManyPostalAddressable
	{
		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.PostalAddress" /> Records
		/// </summary>
		ICollection<PostalAddress> Addresses
		{
			get;
			set;
		}
	}
}