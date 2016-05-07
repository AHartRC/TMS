#region Library Imports

using System;
using System.ComponentModel.DataAnnotations;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface IPersonable : IHomeable, IMailable, IBillable, IShippable
	{
		[MaxLength(64)]
		string FirstName
		{
			get;
			set;
		}

		[MaxLength(64)]
		string MiddleName
		{
			get;
			set;
		}

		[MaxLength(64)]
		string LastName
		{
			get;
			set;
		}

		[MaxLength(64)]
		string Hometown
		{
			get;
			set;
		}

		[MaxLength(64)]
		string CurrentTown
		{
			get;
			set;
		}

		[DataType(DataType.Date)]
		DateTime? BirthDate
		{
			get;
			set;
		}
	}
}