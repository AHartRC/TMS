namespace TechnicalMarineSolutions.Interfaces.Base
{
	#region Library Imports

	using System;
	using TechnicalMarineSolutions.Enumerators;

	#endregion

	public interface IDuration
	{
		/// <summary>
		///     The scheduled interval. Defaults to Once (0).
		/// </summary>
		DurationInterval Interval
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the event started
		/// </summary>
		DateTime? StartDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the event ended
		/// </summary>
		DateTime? EndDate
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
		TimeSpan? Duration
		{
			get;
			set;
		}
	}
}