using Nop.Data;
using Nop.Plugin.Misc.ProductViewTracker.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ProductViewTracker.Services
{
	public class ProductViewTrackerService : IProductViewTrackerService
	{
		private readonly IRepository<ProductViewTrackerRecords> _productViewTrackerRecordRepository;

		public ProductViewTrackerService(IRepository<ProductViewTrackerRecords> productViewTrackerRecordRepository)
		{
			_productViewTrackerRecordRepository = productViewTrackerRecordRepository;
		}

		/// <summary>
		/// Logs the specified record.
		/// </summary>
		/// <param name="record">The record.</param>
		public void Log(ProductViewTrackerRecords record)
		{
			if (record == null)
			{
				throw new ArgumentNullException(nameof(record));
			}

			_productViewTrackerRecordRepository.InsertAsync(record);
		}
	}
}
