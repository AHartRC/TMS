namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System;
	using System.Collections.Generic;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;
	using TechnicalMarineSolutions.Models.Base;

	#endregion

	public class Information : BaseModel, IInformation
	{
		public Information()
		{
		}

		#region Implementation of IUserable

		/// <summary>
		///     The ID of the <see cref="IUserable.User" /> Record
		/// </summary>
		public long UserId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.User" /> Record
		/// </summary>
		public User User
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IDisplayName

		/// <summary>
		///     The Name to be used when displaying this record
		/// </summary>
		public string DisplayName
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IFullName

		/// <summary>
		///     The First (Given) Name of the person
		/// </summary>
		public string FirstName
		{
			get;
			set;
		}

		/// <summary>
		///     The Middle Name of the person
		/// </summary>
		public string MiddleName
		{
			get;
			set;
		}

		/// <summary>
		///     The Last (Sur) Name of the Person
		/// </summary>
		public string LastName
		{
			get;
			set;
		}

		#endregion

		#region Implementation of INote

		/// <summary>
		///     Notes that are available to the public
		/// </summary>
		public string PublicNotes
		{
			get;
			set;
		}

		/// <summary>
		///     Notes that are available to administrators and moderators only
		/// </summary>
		public string PrivateNotes
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IInformation

		/// <summary>
		///     Where the user grew up
		/// </summary>
		public string Hometown
		{
			get;
			set;
		}

		/// <summary>
		///     Where the user currently resides
		/// </summary>
		public string CurrentTown
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the user registered
		/// </summary>
		public DateTime RegisterDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and possibly Time that the user was born
		/// </summary>
		public DateTime? BirthDate
		{
			get;
			set;
		}

		#endregion
	}
}