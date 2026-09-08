using System.Globalization;

namespace Ex01.OrderPricingService;

public interface IOrderPricingService
{
    decimal CalculateTotal(string countryCode, decimal subTotal);
}
