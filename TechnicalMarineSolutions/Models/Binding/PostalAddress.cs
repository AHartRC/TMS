#region Library Imports

using System.Collections.Generic;

#endregion

namespace TechnicalMarineSolutions.Models.Binding
{
	public class PostalAddress
	{
		public PostalAddress()
		{
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

		public long PersonId
		{
			get;
			set;
		}

		public long AddressType
		{
			get;
			set;
		}

		public long RecordStatus
		{
			get;
			set;
		}

		public string Recipient
		{
			get;
			set;
		}

		public string Attention
		{
			get;
			set;
		}

		public string Address1
		{
			get;
			set;
		}

		public string Address2
		{
			get;
			set;
		}

		public string City
		{
			get;
			set;
		}

		public string State
		{
			get;
			set;
		}

		public string PostalCode
		{
			get;
			set;
		}

		public virtual Person Person
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

		public virtual ICollection<Image> Images
		{
			get;
			set;
		}
	}
}