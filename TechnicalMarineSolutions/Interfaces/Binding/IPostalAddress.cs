namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Enumerators;
	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;

	#endregion

	public interface IPostalAddress
		: IBaseModel,
		  IStreetAddress,
		  IPier,
		  IRecipient,
		  INote,
		  IManyAppointmentable,
		  IManyImageable,
		  IManyInformationable,
		  IManyManufacturerable,
		  IManyProjectable,
		  IManyStepable,
		  IManyVehicleable
	{
	}
}