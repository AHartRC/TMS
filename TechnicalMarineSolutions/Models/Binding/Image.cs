#region Library Imports

using System.Collections.Generic;

#endregion

namespace TechnicalMarineSolutions.Models.Binding
{
	public class Image
	{
		public Image()
		{
			Users = new HashSet<User>();
			People = new HashSet<Person>();
			Addresses = new HashSet<PostalAddress>();
			Projects = new HashSet<Project>();
			Appointments = new HashSet<Appointment>();
			Tasks = new HashSet<Task>();
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

		public long ImageStatus
		{
			get;
			set;
		}

		public decimal Width
		{
			get;
			set;
		}

		public decimal Height
		{
			get;
			set;
		}

		public string Source
		{
			get;
			set;
		}

		public string AltText
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public string Author
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

		public virtual ICollection<User> Users
		{
			get;
			set;
		}

		public virtual ICollection<Person> People
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

		public virtual ICollection<Task> Tasks
		{
			get;
			set;
		}
	}
}