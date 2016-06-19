namespace TechnicalMarineSolutions.Interfaces.Mapping.Many
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IManyPartOrderItemable
	{
		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.PartOrderItem" /> Records
		/// </summary>
		ICollection<PartOrderItem> PartOrderItems
		{
			get;
			set;
		}
	}
}