namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;

	#endregion

	public interface IWorkOrderItem
		: IBaseModel,
		  IOrderable,
		  IInventoryable,
		  IQuantity,
		  ICost,
		  IDescription,
		  INote,
		  IManyImageable
	{ }
}