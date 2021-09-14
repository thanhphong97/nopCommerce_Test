using Nop.Core;
using System;

namespace Nop.Plugin.Misc.ProductViewTracker.Domains
{
    public class ProductViewTrackerRecords : BaseEntity
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string ProductName { get; set; }
        public string IpAddress { get; set; }
        public bool IsRegistered { get; set; }
        public DateTime logTime { get; set; }
    }
}
