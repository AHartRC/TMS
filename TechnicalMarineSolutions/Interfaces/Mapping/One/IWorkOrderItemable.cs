namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IWorkOrderItemable
	{
		/// <summary>
		///     The ID of the <see cref="WorkOrderItem" /> Record
		/// </summary>
		long? WorkOrderItemId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.WorkOrderItem" /> Record
		/// </summary>
		WorkOrderItem WorkOrderItem
		{
			get;
			set;
		}
	}
}