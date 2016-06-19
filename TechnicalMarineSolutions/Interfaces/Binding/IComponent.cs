namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;

	#endregion

	public interface IComponent
		: IBaseModel,
		  IManufacturerable,
		  ICategorizable,
		  IRetailItem,
		  ICost,
		  IQuantity,
		  IName,
		  ITitle,
		  IDescription,
		  INote,
		  IManyAppointmentable,
		  IManyEngineable,
		  IManyImageable,
		  IManyInformationable,
		  IManyManufacturerable,
		  IManyOrderable,
		  IManyPartable,
		  IManyProjectable,
		  IManyVehicleable
	{ }
}