namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;
	using TechnicalMarineSolutions.Models.Base;

	#endregion

	public class PartOrderItem : BaseModel, IPartOrderItem
	{
		public PartOrderItem()
		{
			Errors = new HashSet<AppError>();
			Images = new HashSet<Image>();
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

		#region Implementation of IPartable

		/// <summary>
		///     The ID of the <see cref="IPartable.Part" /> Record
		/// </summary>
		public long PartId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Part" /> Record
		/// </summary>
		public System.Web.UI.WebControls.WebParts.Part Part
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
		///         Values such as 98.6 will be treated as 986%.
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

		#region Implementation of IManyImageable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Image" /> Records
		/// </summary>
		public ICollection<Image> Images
		{
			get;
			set;
		}

		#endregion
	}
}