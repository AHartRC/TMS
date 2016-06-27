namespace TechnicalMarineSolutions.Models.Binding
{
	#region Library Imports

	using System;
	using System.Collections.Generic;
	using TechnicalMarineSolutions.Interfaces.Binding;

	#endregion

	public class AppError : IAppError
	{
		public AppError()
		{
			//Appointments = new HashSet<Appointment>();
			//Categories = new HashSet<Category>();
			//Components = new HashSet<Component>();
			//Engines = new HashSet<Engine>();
			//Errors = new HashSet<AppError>();
			//Images = new HashSet<Image>();
			//UserInformation = new HashSet<Information>();
			//Inventories = new HashSet<Inventory>();
			//Manufacturers = new HashSet<Manufacturer>();
			//Orders = new HashSet<Order>();
			//Parts = new HashSet<Part>();
			//PartOrderItems = new HashSet<PartOrderItem>();
			//Addresses = new HashSet<PostalAddress>();
			//Projects = new HashSet<Project>();
			//Steps = new HashSet<Step>();
			//SubCategories = new HashSet<SubCategory>();
			//TertiaryCategories = new HashSet<TertiaryCategory>();
			//Users = new HashSet<User>();
			//Vehicles = new HashSet<Vehicle>();
			//WorkOrderItems = new HashSet<WorkOrderItem>();
		}

		#region Implementation of IElmahError

		public Guid ErrorId
		{
			get;
			set;
		}

		public string Application
		{
			get;
			set;
		}

		public string Host
		{
			get;
			set;
		}

		public string Type
		{
			get;
			set;
		}

		public string Source
		{
			get;
			set;
		}

		public string Message
		{
			get;
			set;
		}

		public string User
		{
			get;
			set;
		}

		public int StatusCode
		{
			get;
			set;
		}

		public DateTime TimeUtc
		{
			get;
			set;
		}

		public int Sequence
		{
			get;
			set;
		}

		public string AllXml
		{
			get;
			set;
		}

		#endregion
	}
}