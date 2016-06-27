namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System;
	using System.Collections.Generic;
	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;
	using TechnicalMarineSolutions.Models.Base;

	#endregion

	public class Order : BaseModel, IFullOrder
	{
		public Order()
		{
		}

		#region Implementation of IUserable

		/// <summary>
		///     The ID of the <see cref="IUserable.User" /> Record
		/// </summary>
		public long UserId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.User" /> Record
		/// </summary>
		public User User
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IOrder

		/// <summary>
		///     A unique identifier that corresponds to the Order/Transaction ID of a third party
		/// </summary>
		public string OrderNumber
		{
			get;
			set;
		}

		/// <summary>
		///     A tracking number that was provided by a third party for package tracking
		/// </summary>
		public string TrackingNumber
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the order was placed
		/// </summary>
		public DateTime OrderDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the order is expected to ship
		/// </summary>
		public DateTime? ExpectedShipDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the order shipped
		/// </summary>
		public DateTime? ShipDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the order is expected to be received
		/// </summary>
		public DateTime? ExpectedReceiptDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the order was received
		/// </summary>
		public DateTime? ReceiptDate
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IPostalAddressable

		/// <summary>
		///     The ID of the <see cref="IPostalAddressable.Address" /> Record
		/// </summary>
		public long AddressId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.PostalAddress" /> Record
		/// </summary>
		public PostalAddress Address
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