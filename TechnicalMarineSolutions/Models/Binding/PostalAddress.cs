namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Enumerators;
	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Models.Base;

	#endregion

	public class PostalAddress : BaseModel, IPostalAddress
	{
		public PostalAddress()
		{
			Appointments = new HashSet<Appointment>();
			Errors = new HashSet<AppError>();
			Images = new HashSet<Image>();
			UserInformation = new HashSet<Information>();
			Manufacturers = new HashSet<Manufacturer>();
			Projects = new HashSet<Project>();
			Steps = new HashSet<Step>();
			Vehicles = new HashSet<Vehicle>();
		}
		#region Implementation of IStreetAddress

		/// <summary>
		///     The Type of Address
		/// </summary>
		public PostalAddressType AddressType
		{
			get;
			set;
		}

		/// <summary>
		///     The Number and Street of the location
		/// </summary>
		public string Address1
		{
			get;
			set;
		}

		/// <summary>
		///     Additional information such as Apartment or Suite number
		/// </summary>
		public string Address2
		{
			get;
			set;
		}

		/// <summary>
		///     The City of which the location is in
		/// </summary>
		public string City
		{
			get;
			set;
		}

		/// <summary>
		///     The State of which the location is in
		/// </summary>
		public string State
		{
			get;
			set;
		}

		/// <summary>
		///     The Postal Code for the location
		/// </summary>
		public string PostalCode
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IPier

		/// <summary>
		///     The identifier of the specific pier at the <see cref="PostalAddress" />
		/// </summary>
		public string Pier
		{
			get;
			set;
		}

		/// <summary>
		///     The specific position of the <see cref="IPier.Pier" /> at the <see cref="PostalAddress" />
		/// </summary>
		public string Position
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IRecipient

		/// <summary>
		///     The name of the intended Recipient
		/// </summary>
		public string Recipient
		{
			get;
			set;
		}

		/// <summary>
		///     The name of the person associated at the location
		/// </summary>
		public string Attention
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
	}
}