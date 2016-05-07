#region Library Imports

using System;
using System.Collections.Generic;

#endregion

namespace TechnicalMarineSolutions.Models.Binding
{
	public class Project
	{
		public Project()
		{
			Participants = new HashSet<Person>();
			Addresses = new HashSet<PostalAddress>();
			Appointments = new HashSet<Appointment>();
			Tasks = new HashSet<Task>();
			Images = new HashSet<Image>();
		}

		public long Id
		{
			get;
			set;
		}

		public long RecordStatus
		{
			get;
			set;
		}

		public long ProjectStatus
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

		public DateTime? ProjectedStartDate
		{
			get;
			set;
		}

		public DateTime? ProjectedEndDate
		{
			get;
			set;
		}

		public TimeSpan? EstimatedDuration
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

		public TimeSpan? TotalDuration
		{
			get;
			set;
		}

		public virtual ICollection<Person> Participants
		{
			get;
			set;
		}

		public virtual ICollection<PostalAddress> Addresses
		{
			get;
			set;
		}

		public virtual ICollection<Appointment> Appointments
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