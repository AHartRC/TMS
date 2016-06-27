namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;

	#endregion

	public interface IPartOrderItem
		: IBaseModel,
		  IOrderable,
		  IPartable,
		  IQuantity,
		  ICost,
		  IDescription,
		  INote {}
}