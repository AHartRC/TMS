using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalMarineSolutions.Interfaces.Base
{
	public interface IRecipient
	{
		/// <summary>
		///     The name of the intended Recipient
		/// </summary>
		string Recipient
		{
			get;
			set;
		}

		/// <summary>
		///     The name of the person associated at the location
		/// </summary>
		string Attention
		{
			get;
			set;
		}
	}
}
