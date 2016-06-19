namespace TechnicalMarineSolutions.Interfaces.Mapping.One
{
	#region Library Imports

	using System;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public interface IAppErrorable
	{
		Guid ErrorId
		{
			get;
			set;
		}

		AppError Error
		{
			get;
			set;
		}
	}
}