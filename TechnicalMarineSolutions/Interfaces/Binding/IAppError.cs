namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;

	#endregion

	public interface IAppError
		: IElmahError,
		  IManyAppointmentable,
		  IManyCategoryable,
		  IManyComponentable,
		  IManyEngineable,
		  IManyImageable,
		  IManyInformationable,
		  IManyInventoryable,
		  IManyManufacturerable,
		  IManyOrderable,
		  IManyPartable,
		  IManyPartOrderItemable,
		  IManyPostalAddressable,
		  IManyProjectable,
		  IManyStepable,
		  IManySubCategoryable,
		  IManyTertiaryCategoryable,
		  IManyUserable,
		  IManyVehicleable,
		  IManyWorkOrderItemable {}
}