namespace Microsoft.eShopWeb.Web.ViewModels;

public class OrderDetailViewModel : OrderViewModel
{
    //second change
    public List<OrderItemViewModel> OrderItems { get; set; } = new();
}
