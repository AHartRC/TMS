namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;

	#endregion

	public interface IProject
		: IBaseModel,
		  ICategorizable,
		  IProgressStatus,
		  IName,
		  ITitle,
		  IDescription,
		  IProjectedDuration,
		  IDuration,
		  INote,
		  IManyAppointmentable,
		  IManyComponentable,
		  IManyEngineable,
		  IManyImageable,
		  IManyInformationable,
		  IManyManufacturerable,
		  IManyOrderable,
		  IManyPartable,
		  IManyPostalAddressable,
		  IManyStepable,
		  IManyVehicleable
	{ }
}