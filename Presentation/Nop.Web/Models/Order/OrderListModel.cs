using Nop.Web.Framework.Models;

namespace Nop.Web.Models.Order
{
    /// <summary>
    /// Represents an order list model
    /// </summary>
    public partial record OrderListModel : BasePagedListModel<CustomerOrderListModel.OrderDetailsModel>
    {
    }
}