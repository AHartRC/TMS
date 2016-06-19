namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Models.Base;

	#endregion

	public class Image : BaseModel, IImage
	{
		public Image()
		{
			Appointments = new HashSet<Appointment>();
			Categories = new HashSet<Category>();
			Components = new HashSet<Component>();
			Engines = new HashSet<Engine>();
			Errors = new HashSet<AppError>();
			UserInformation = new HashSet<Information>();
			Inventories = new HashSet<Inventory>();
			Manufacturers = new HashSet<Manufacturer>();
			Parts = new HashSet<Part>();
			Addresses = new HashSet<PostalAddress>();
			Projects = new HashSet<Project>();
			Steps = new HashSet<Step>();
			SubCategories = new HashSet<SubCategory>();
			TertiaryCategories = new HashSet<TertiaryCategory>();
			Vehicles = new HashSet<Vehicle>();
		}
		#region Implementation of IMedia

		/// <summary>
		///     The file path or URL of the Media
		/// </summary>
		public string Source
		{
			get;
			set;
		}

		/// <summary>
		///     Text to display if the <see cref="IMedia.Source" /> is invalid
		/// </summary>
		public string AlternateText
		{
			get;
			set;
		}

		#endregion

		#region Implementation of I2Dimension

		/// <summary>
		///     <para>The Width of the Object</para>
		/// </summary>
		public decimal Width
		{
			get;
			set;
		}

		/// <summary>
		///     <para>The Height of the Object</para>
		/// </summary>
		public decimal Height
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

		#region Implementation of IAuthor

		/// <summary>
		///     <para>The Name of the Author that created the content</para>
		/// </summary>
		public string Author
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

		#region Implementation of IManyCategoryable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Category" /> Records
		/// </summary>
		public ICollection<Category> Categories
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

		#region Implementation of IManyInventoryable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.Inventory" /> Records
		/// </summary>
		public ICollection<Inventory> Inventories
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

		#region Implementation of IManySubCategoryable

		/// <summary>
		///     An <see cref="ICollection{T}" /> of <see cref="TechnicalMarineSolutions.Models.Binding.SubCategory" /> Records
		/// </summary>
		public ICollection<SubCategory> SubCategories
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