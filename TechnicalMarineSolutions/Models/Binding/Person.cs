#region Library Imports

using System;
using System.Collections.Generic;

#endregion

namespace TechnicalMarineSolutions.Models.Binding
{
	public class Person
	{
		public Person()
		{
			Addresses = new HashSet<PostalAddress>();
			Projects = new HashSet<Project>();
			Appointments = new HashSet<Appointment>();
			Tasks = new HashSet<Task>();
			Images = new HashSet<Image>();
		}

		public long Id
		{
			get;
			set;
		}

		public long UserId
		{
			get;
			set;
		}

		public long RecordStatus
		{
			get;
			set;
		}

		public string FirstName
		{
			get;
			set;
		}

		public string MiddleName
		{
			get;
			set;
		}

		public string LastName
		{
			get;
			set;
		}

		public string Hometown
		{
			get;
			set;
		}

		public string CurrentTown
		{
			get;
			set;
		}

		public DateTime? BirthDate
		{
			get;
			set;
		}

		public virtual User User
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

		// TODO: Are we going to assign tasks to users? Will GD be considering himself a user? Should I use this to indicate which tasks correspond to which people?
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