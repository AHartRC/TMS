#region Library Imports

using System.Collections.Generic;

#endregion

namespace TechnicalMarineSolutions.Models.Binding
{
	public class User
	{
		public User()
		{
			People = new HashSet<Person>();
			Images = new HashSet<Image>();
		}

		public long Id
		{
			get;
			set;
		}

		public string UserId
		{
			get;
			set;
		}

		public string DisplayName
		{
			get;
			set;
		}

		public string Title
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

		public virtual ApplicationUser ApplicationUser
		{
			get;
			set;
		}

		public virtual ICollection<Person> People
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