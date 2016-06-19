namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;

	#endregion

	public interface IImage
		: IBaseModel,
		  IMedia,
		  I2Dimension,
		  IName,
		  IAuthor,
		  IDescription,
		  INote,
		  IManyAppointmentable,
		  IManyCategoryable,
		  IManyComponentable,
		  IManyEngineable,
		  IManyInformationable,
		  IManyInventoryable,
		  IManyManufacturerable,
		  IManyPartable,
		  IManyPostalAddressable,
		  IManyProjectable,
		  IManyStepable,
		  IManySubCategoryable,
		  IManyTertiaryCategoryable,
		  IManyVehicleable {}
}