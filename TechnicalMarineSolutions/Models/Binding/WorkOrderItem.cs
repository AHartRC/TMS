namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;
	using TechnicalMarineSolutions.Models.Base;

	#endregion

	public class WorkOrderItem : BaseModel, IWorkOrderItem
	{
		public WorkOrderItem()
		{
		}

		#region Implementation of IOrderable

		/// <summary>
		///     The ID of the <see cref="IOrderable.Order" /> Record
		/// </summary>
		public long OrderId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Order" /> Record
		/// </summary>
		public Order Order
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IInventoryable

		/// <summary>
		///     The ID of the <see cref="IInventoryable.Inventory" /> Record
		/// </summary>
		public long InventoryId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Inventory" /> Record
		/// </summary>
		public Inventory Inventory
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IQuantity

		/// <summary>
		///     The total amount of the item
		/// </summary>
		public decimal Quantity
		{
			get;
			set;
		}

		#endregion

		#region Implementation of ICost

		/// <summary>
		///     <para>The Cost of the Item</para>
		/// </summary>
		public decimal Cost
		{
			get;
			set;
		}

		/// <summary>
		///     The Discount Percentage to be applied to <see cref="ICost.Cost" />
		///     <value>
		///         <para>The expected value should be already reduced to 0.#</para>
		///         Values such as 98.6 will be treated as 9860%.
		///     </value>
		/// </summary>
		public decimal Discount
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IDescription

		/// <summary>
		///     A brief description that describes what this record entails
		/// </summary>
		public string Description
		{
			get;
			set;
		}

		#endregion

		#region Implementation of INote

		/// <summary>
		///     Notes that are available to the public
		/// </summary>
		public string PublicNotes
		{
			get;
			set;
		}

		/// <summary>
		///     Notes that are available to administrators and moderators only
		/// </summary>
		public string PrivateNotes
		{
			get;
			set;
		}

		#endregion
	}
}