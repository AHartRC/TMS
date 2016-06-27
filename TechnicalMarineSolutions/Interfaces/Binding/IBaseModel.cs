namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;

	#endregion

	public interface IBaseModel : IIdentifier, IEntityType, IRecordStatus {}
}