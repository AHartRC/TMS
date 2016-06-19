namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;

	#endregion

	public interface IInventory
		: IBaseModel,
		  IPartable,
		  ICategorizable,
		  IName,
		  ITitle,
		  IDescription,
		  IRetailItem,
		  ICost,
		  IQuantity,
		  INote,
		  IManyImageable,
		  IManyWorkOrderItemable
	{ }
}