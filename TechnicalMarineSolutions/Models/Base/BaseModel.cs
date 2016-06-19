namespace TechnicalMarineSolutions.Models.Base
{
	#region Library Imports

	using System.Collections.Generic;
	using TechnicalMarineSolutions.Enumerators;
	using TechnicalMarineSolutions.Interfaces.Binding;
	using TechnicalMarineSolutions.Models.Binding;

	#endregion

	public abstract class BaseModel : IBaseModel
	{
		#region Implementation of IIdentifier

		/// <summary>
		///     The Primary Identifier of the record. This is typically the primary key column.
		/// </summary>
		public long Id
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IEntityType

		/// <summary>
		///     An identifier that distinguishes one entity type from another
		/// </summary>
		public long EntityTypeId
		{
			get;
		}

		#endregion

		#region Implementation of IRecordStatus

		/// <summary>
		///     The Current status of the Record
		///     <para>This is to be used for internal purposes</para>
		///     This field will be utilized for flagging records as spam/archived/deleted/featured/etc
		/// </summary>
		public RecordStatus RecordStatus
		{
			get;
			set;
		}

		#endregion

		#region Implementation of IManyAppErrorable

		public ICollection<AppError> Errors
		{
			get;
			set;
		}

		#endregion
	}
}