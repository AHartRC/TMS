namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;

	#endregion

	public interface IVehicle
		: IBaseModel,
		  IManufacturerable,
		  ICategorizable,
		  IRetailItem,
		  ICost,
		  IName,
		  ITitle,
		  IDescription,
		  INote,
		  IManyAppointmentable,
		  IManyComponentable,
		  IManyEngineable,
		  IManyImageable,
		  IManyInformationable,
		  IManyPartable,
		  IManyProjectable
	{
		/// <summary>
		///     The unique Vehicle Identification Number
		/// </summary>
		string VIN
		{
			get;
			set;
		}

		/// <summary>
		///     The Year of manufacturer
		/// </summary>
		int Year
		{
			get;
			set;
		}

		/// <summary>
		///     The Make of the Vehicle
		/// </summary>
		string Make
		{
			get;
			set;
		}

		/// <summary>
		///     The Model of the Vehicle
		/// </summary>
		string Model
		{
			get;
			set;
		}

		/// <summary>
		///     The Edition of the Vehicle
		/// </summary>
		string Edition
		{
			get;
			set;
		}
	}
}