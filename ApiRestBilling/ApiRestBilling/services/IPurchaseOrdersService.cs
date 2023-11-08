using ApiRestBilling.Models;

namespace ApiRestBilling.Controllers.services
{
    public interface IPurchaseOrdersService
    {
        Task<decimal> CheckUnitPrice(OrderItem detalle);
        Task<decimal> CalculateSubtotalOrderItem(OrderItem Item);
        decimal CalcularTotalOrderItems(List<OrderItem> Item);
        
        
    }
}