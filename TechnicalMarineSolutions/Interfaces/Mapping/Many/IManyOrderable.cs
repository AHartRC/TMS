namespace TechnicalMarineSolutions.Interfaces.Mapping.Many
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IManyOrderable
	{
		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Order" /> Records
		/// </summary>
		ICollection<Order> Orders
		{
			get;
			set;
		}
	}
}