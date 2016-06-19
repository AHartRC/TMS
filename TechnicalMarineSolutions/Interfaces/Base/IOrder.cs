namespace TechnicalMarineSolutions.Interfaces.Base
{
	#region Library Imports

	using System;

	#endregion

	public interface IOrder
	{
		/// <summary>
		///     A unique identifier that corresponds to the Order/Transaction ID of a third party
		/// </summary>
		string OrderNumber
		{
			get;
			set;
		}

		/// <summary>
		///     A tracking number that was provided by a third party for package tracking
		/// </summary>
		string TrackingNumber
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the order was placed
		/// </summary>
		DateTime OrderDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the order is expected to ship
		/// </summary>
		DateTime? ExpectedShipDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the order shipped
		/// </summary>
		DateTime? ShipDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the order is expected to be received
		/// </summary>
		DateTime? ExpectedReceiptDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the order was received
		/// </summary>
		DateTime? ReceiptDate
		{
			get;
			set;
		}
	}
}