#region Library Imports

using TechnicalMarineSolutions.Enumerators;
using TechnicalMarineSolutions.Interfaces;

#endregion

namespace TechnicalMarineSolutions.Models.Base
{
	public abstract class BaseModel : IBaseModel
	{
		public long Id
		{
			get;
			set;
		}

		public ulong EntityTypeId => 9471803198086783705;

		public RecordStatus Status
		{
			get;
			set;
		}
	}
}