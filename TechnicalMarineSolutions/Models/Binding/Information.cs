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
			Appointments = new HashSet<Appointment>();
			Components = new HashSet<Component>();
			Engines = new HashSet<Engine>();
			Errors = new HashSet<AppError>();
			Images = new HashSet<Image>();
			UserInformation = new HashSet<Information>();
			Manufacturers = new HashSet<Manufacturer>();
			Orders = new HashSet<Order>();
			Addresses = new HashSet<PostalAddress>();
			Projects = new HashSet<Project>();
			Steps = new HashSet<Step>();
			Vehicles = new HashSet<Vehicle>();
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

		#region Implementation of IManyAppointmentable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Appointment" /> Records
		/// </summary>
		public ICollection<Appointment> Appointments
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyComponentable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Component" /> Records
		/// </summary>
		public ICollection<Component> Components
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyEngineable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Engine" /> Records
		/// </summary>
		public ICollection<Engine> Engines
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyImageable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Image" /> Records
		/// </summary>
		public ICollection<Image> Images
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyInformationable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Information" /> Records
		/// </summary>
		public ICollection<Information> UserInformation
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyManufacturerable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Manufacturer" /> Records
		/// </summary>
		public ICollection<Manufacturer> Manufacturers
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyOrderable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Order" /> Records
		/// </summary>
		public ICollection<Order> Orders
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyPostalAddressable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.PostalAddress" /> Records
		/// </summary>
		public ICollection<PostalAddress> Addresses
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyProjectable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Project" /> Records
		/// </summary>
		public ICollection<Project> Projects
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyStepable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Step" /> Records
		/// </summary>
		public ICollection<Step> Steps
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyVehicleable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Vehicle" /> Records
		/// </summary>
		public ICollection<Vehicle> Vehicles
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