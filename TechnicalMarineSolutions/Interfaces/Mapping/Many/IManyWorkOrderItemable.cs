namespace TechnicalMarineSolutions.Interfaces.Mapping.Many
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IManyWorkOrderItemable
	{
		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.WorkOrderItem" /> Records
		/// </summary>
		ICollection<WorkOrderItem> WorkOrderItems
		{
			get;
			set;
		}
	}
}