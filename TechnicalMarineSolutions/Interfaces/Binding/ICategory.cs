namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;

	#endregion

	public interface ICategory
		: IBaseModel,
		  IName,
		  ITitle,
		  IDescription,
		  INote,
		  IManyComponentable,
		  IManyEngineable,
		  IManyImageable,
		  IManyManufacturerable,
		  IManyPartable,
		  IManyProjectable,
		  IManyStepable,
		  IManySubCategoryable,
		  IManyTertiaryCategoryable,
		  IManyVehicleable
	{ }
}