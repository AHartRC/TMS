namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System;
	using System.Collections.Generic;
	using TechnicalMarineSolutions.Enumerators;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;
	using TechnicalMarineSolutions.Models.Base;

	#endregion

	public class Appointment : BaseModel, IAppointment
	{
		public Appointment()
		{
		}

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

		#region Implementation of IProgressStatus

		/// <summary>
		///     The Progress Status of the event
		///     <para>This is to indicate how far along the event is</para>
		/// </summary>
		public ProgressStatus ProgressStatus
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IName

		/// <summary>
		///     A Brief Name that describes the content in as few words as possible
		/// </summary>
		public string Name
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

		#region Implementation of IScheduledDuration

		/// <summary>
		///     The Date and Time that the event is scheduled to start
		/// </summary>
		public DateTime? ScheduledStartDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the event is scheduled to end
		/// </summary>
		public DateTime? ScheduledEndDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Total Duration that the event is scheduled to take
		/// </summary>
		public TimeSpan? ScheduledDuration
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IDuration

		/// <summary>
		///     The scheduled interval. Defaults to Once (0).
		/// </summary>
		public DurationInterval Interval
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the event started
		/// </summary>
		public DateTime? StartDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the event ended
		/// </summary>
		public DateTime? EndDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Total Duration of the event
		///     <para>This field indicates how long specifically that the event took</para>
		///     This is to differentiate the amount of time between the start and end dates versus time actually spent towards the
		///     corresponding event
		/// </summary>
		public TimeSpan? Duration
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