namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;

	#endregion

	public interface IAppointment
		: IBaseModel,
		  IPostalAddressable,
		  IProgressStatus,
		  IName,
		  IDescription,
		  IScheduledDuration,
		  IDuration,
		  INote {}
}