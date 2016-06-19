namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;

	#endregion

	public interface ISubCategory
		: IBaseModel,
		  ICategoryable,
		  IName,
		  ITitle,
		  IDescription,
		  INote,
		  IManyAppointmentable,
		  IManyComponentable,
		  IManyEngineable,
		  IManyImageable,
		  IManyManufacturerable,
		  IManyPartable,
		  IManyProjectable,
		  IManyStepable,
		  IManyTertiaryCategoryable,
		  IManyVehicleable
	{ }
}