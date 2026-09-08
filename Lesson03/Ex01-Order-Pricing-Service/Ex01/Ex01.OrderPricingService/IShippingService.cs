namespace Ex01.OrderPricingService;

public interface IShippingService
{
    decimal GetShippingCosts(string countryCode, decimal subTotal);
}
