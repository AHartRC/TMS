#region Library Imports

using System;
using System.Collections.Generic;

#endregion

namespace TechnicalMarineSolutions.Models.Binding
{
	public class Appointment
	{
		public Appointment()
		{
			Participants = new HashSet<Person>();
			Projects = new HashSet<Project>();
			Tasks = new HashSet<Task>();
			Images = new HashSet<Image>();
		}

		public long Id
		{
			get;
			set;
		}

		public long PostalAddressId
		{
			get;
			set;
		}

		public long RecordStatus
		{
			get;
			set;
		}

		public long AppointmentStatus
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		public string Notes
		{
			get;
			set;
		}

		public DateTime? ScheduledDate
		{
			get;
			set;
		}

		public DateTime? StartDate
		{
			get;
			set;
		}

		public DateTime? EndDate
		{
			get;
			set;
		}

		public TimeSpan? ScheduledDuration
		{
			get;
			set;
		}

		public TimeSpan? EstimatedDuration
		{
			get;
			set;
		}

		public TimeSpan? TotalDuration
		{
			get;
			set;
		}

		public virtual PostalAddress PostalAddress
		{
			get;
			set;
		}

		public virtual ICollection<Person> Participants
		{
			get;
			set;
		}

		public virtual ICollection<Project> Projects
		{
			get;
			set;
		}

		public virtual ICollection<Task> Tasks
		{
			get;
			set;
		}

		public virtual ICollection<Image> Images
		{
			get;
			set;
		}
	}
}