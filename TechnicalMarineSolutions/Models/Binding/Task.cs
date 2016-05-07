#region Library Imports

using System;
using System.Collections.Generic;

#endregion

namespace TechnicalMarineSolutions.Models.Binding
{
	public class Task
	{
		public Task()
		{
			Participants = new HashSet<Person>();
			Addresses = new HashSet<PostalAddress>();
			Projects = new HashSet<Project>();
			Appointments = new HashSet<Appointment>();
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

		public int Difficulty
		{
			get;
			set;
		}

		public TimeSpan EstimatedDuration
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

		public virtual ICollection<Project> Projects
		{
			get;
			set;
		}

		public virtual ICollection<Appointment> Appointments
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