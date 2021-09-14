using Nop.Plugin.Misc.ProductViewTracker.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ProductViewTracker.Services
{
	public interface IProductViewTrackerService
	{
		/// <summary>
		/// Logs the specified record.
		/// </summary>
		/// <param name="record">The record.</param>
		void Log(ProductViewTrackerRecords record);
	}
}
