namespace TechnicalMarineSolutions.Interfaces.Binding
{
	#region Library Imports

	using TechnicalMarineSolutions.Enumerators;
	using TechnicalMarineSolutions.Interfaces.Base;
	using TechnicalMarineSolutions.Interfaces.Mapping.Many;
	using TechnicalMarineSolutions.Interfaces.Mapping.One;

	#endregion

	public interface IStep
		: IBaseModel,
		  ICategorizable,
		  IName,
		  IDescription,
		  IDuration,
		  INote,
		  IManyAppointmentable,
		  IManyImageable,
		  IManyInformationable,
		  IManyProjectable
	{
		/// <summary>
		///     The level of difficulty of the step
		/// </summary>
		DifficultyLevel Difficulty
		{
			get;
			set;
		}
	}
}