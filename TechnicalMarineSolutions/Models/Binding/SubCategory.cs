namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;
	using TechnicalMarineSolutions.Models.Base;

	#endregion

	public class SubCategory : BaseModel, ISubCategory
	{
		public SubCategory()
		{
			Appointments = new HashSet<Appointment>();
			Components = new HashSet<Component>();
			Engines = new HashSet<Engine>();
			Errors = new HashSet<AppError>();
			Images = new HashSet<Image>();
			Manufacturers = new HashSet<Manufacturer>();
			Parts = new HashSet<Part>();
			Projects = new HashSet<Project>();
			Steps = new HashSet<Step>();
			TertiaryCategories = new HashSet<TertiaryCategory>();
			Vehicles = new HashSet<Vehicle>();
		}
		#region Implementation of ICategoryable

		/// <summary>
		///     The ID of the <see cref="ICategoryable.Category" /> Record
		/// </summary>
		public long? CategoryId
		{
			get;
			set;
		}

		/// <summary>
		///     The <see cref="TechnicalMarineSolutions.Models.Binding.Category" /> record
		/// </summary>
		public Category Category
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IName

		/// <summary>
		///     A Brief Name that describes the content in as few words as possible
		/// </summary>
		public string Name
		{
			get;
			set;
		}

		#endregion

		#region Implementation of ITitle

		/// <summary>
		///     A Title or Caption that describes the record
		/// </summary>
		public string Title
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IDescription

		/// <summary>
		///     A brief description that describes what this record entails
		/// </summary>
		public string Description
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

		#region Implementation of IManyPartable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Part" /> Records
		/// </summary>
		public ICollection<Part> Parts
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

		#region Implementation of IManyTertiaryCategoryable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.TertiaryCategory" /> Records
		/// </summary>
		public ICollection<TertiaryCategory> TertiaryCategories
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