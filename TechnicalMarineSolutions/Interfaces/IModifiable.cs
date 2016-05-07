#region Library Imports

using System;
using TechnicalMarineSolutions.Models.Binding;

#endregion

namespace TechnicalMarineSolutions.Interfaces
{
	public interface IModifiable
	{
		/// <summary>
		///     Indicates who created this record
		/// </summary>
		long CreatedById
		{
			get;
			set;
		}

		/// <summary>
		///     Indicates who last modified this record
		/// </summary>
		long LastModifiedById
		{
			get;
			set;
		}

		/// <summary>
		///     Indicates when this record was created
		/// </summary>
		DateTime CreatedOn
		{
			get;
			set;
		}

		/// <summary>
		///     Indicates when this record was last modified
		/// </summary>
		DateTime LastModifiedOn
		{
			get;
			set;
		}

		/// <summary>
		///     The user that created the record
		/// </summary>
		User CreatedBy
		{
			get;
			set;
		}

		/// <summary>
		///     The user that last modified the record
		/// </summary>
		User LastModifiedBy
		{
			get;
			set;
		}
	}
}