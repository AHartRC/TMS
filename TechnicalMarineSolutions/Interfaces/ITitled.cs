#region Library Imports

using System.ComponentModel.DataAnnotations;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface ITitled
	{
		[MaxLength(256)]
		string Title
		{
			get;
			set;
		}
	}
}