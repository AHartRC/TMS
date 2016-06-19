namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;

	#endregion

	public interface IManufacturer
		: IBaseModel,
		  IPostalAddressable,
		  ICategorizable,
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
		  IManyProjectable,
		  IManyVehicleable
	{ }
}