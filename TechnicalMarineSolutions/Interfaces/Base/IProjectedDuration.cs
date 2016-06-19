namespace TechnicalMarineSolutions.Interfaces.Base
{
	#region Library Imports

	using System;

	#endregion

	public interface IProjectedDuration
	{
		/// <summary>
		///     The Date and Time that the event is projected to start
		/// </summary>
		DateTime? ProjectedStartDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the event is projected to end
		/// </summary>
		DateTime? ProjetedEndDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Total Duration that the event is projected to take
		///     <para>This field indicates how long specifically that the event is projected to take</para>
		///     This is to differentiate the amount of time between the start and end dates versus time actually projected towards
		///     the corresponding event
		/// </summary>
		TimeSpan? ProjectedDuration
		{
			get;
			set;
		}
	}
}