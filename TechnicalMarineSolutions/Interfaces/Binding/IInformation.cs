namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using System;
	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;

	#endregion

	public interface IInformation
		: IBaseModel,
		  IUserable,
		  IDisplayName,
		  IFullName,
		  INote,
		  IManyAppointmentable,
		  IManyComponentable,
		  IManyEngineable,
		  IManyImageable,
		  IManyInformationable,
		  IManyManufacturerable,
		  IManyOrderable,
		  IManyPostalAddressable,
		  IManyProjectable,
		  IManyStepable,
		  IManyVehicleable
	{
		/// <summary>
		///     Where the user grew up
		/// </summary>
		string Hometown
		{
			get;
			set;
		}

		/// <summary>
		///     Where the user currently resides
		/// </summary>
		string CurrentTown
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and Time that the user registered
		/// </summary>
		DateTime RegisterDate
		{
			get;
			set;
		}

		/// <summary>
		///     The Date and possibly Time that the user was born
		/// </summary>
		DateTime? BirthDate
		{
			get;
			set;
		}
	}
}