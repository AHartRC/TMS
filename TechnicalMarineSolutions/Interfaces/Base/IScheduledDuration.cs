namespace TechnicalMarineSolutions.Interfaces.Base
{
	#region Library Imports

	using System;

	#endregion

	public interface IScheduledDuration
	{
		/// <summary>
		///     The Date and Time that the event is scheduled to start
		/// </summary>
		DateTime? ScheduledStartDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the event is scheduled to end
		/// </summary>
		DateTime? ScheduledEndDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Total Duration that the event is scheduled to take
		/// </summary>
		TimeSpan? ScheduledDuration
		{
			get;
			set;
		}
	}
}