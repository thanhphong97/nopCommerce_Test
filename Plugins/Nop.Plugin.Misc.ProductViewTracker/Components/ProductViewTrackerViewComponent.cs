using Microsoft.AspNetCore.Mvc;
using Nop.Core;
using Nop.Plugin.Misc.ProductViewTracker.Domains;
using Nop.Plugin.Misc.ProductViewTracker.Services;
using Nop.Services.Catalog;
using Nop.Services.Customers;
using Nop.Web.Framework.Components;
using Nop.Web.Models.Catalog;
using System;
using System.Threading.Tasks;

namespace Nop.Plugin.Misc.ProductViewTracker.Components
{
    [ViewComponent(Name = "ProductViewTracker")]
    public class ProductViewTrackerViewComponent : NopViewComponent
    {
        private readonly ICustomerService _customerService;
        private IProductService _productService;
        private readonly IProductViewTrackerService _productViewTrackerService;
        private IWorkContext _workContext;

        public ProductViewTrackerViewComponent(ICustomerService customerService,
            IProductService productService,
            IProductViewTrackerService productViewTrackerService,
            IWorkContext workContext)
        {
            _customerService = customerService;
            _productService = productService;
            _productViewTrackerService = productViewTrackerService;
            _workContext = workContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(string widgetZone, object additionalData)
        {
            if (!(additionalData is ProductDetailsModel model))
            {
                return Content("");
            }

            //Read from the product service
            var productById = await _productService.GetProductByIdAsync(model.Id);

            if (productById != null)
            {
                var currentCustomer = await _workContext.GetCurrentCustomerAsync();
                //Setup the product to save
                var record = new ProductViewTrackerRecords
                {
                    ProductId = model.Id,
                    ProductName = productById.Name,
                    CustomerId = currentCustomer.Id,
                    IpAddress = currentCustomer.LastIpAddress,
                    IsRegistered = await _customerService.IsRegisteredAsync(currentCustomer),
                    logTime = DateTime.UtcNow
                };
                //Map the values we're interested in to our new entity
                _productViewTrackerService.Log(record);
            }

            return Content("");
        }
    }
}
