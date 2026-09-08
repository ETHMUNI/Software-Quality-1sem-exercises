namespace Ex01.OrderPricingService;

public class OrderPricingService : IOrderPricingService
{
    private readonly IShippingService _shippingService;
    private readonly IDiscountService _discountService;

    public OrderPricingService(IShippingService shippingService, IDiscountService discountService)
    {
        this._shippingService = shippingService;
        this._discountService = discountService;
    }

    public decimal CalculateTotal(string countryCode, decimal subTotal)
    {
        // initialize shipping
        var shipping = _shippingService.GetShippingCosts(countryCode, subTotal);
        // initialize discount
        var discount = _discountService.GetDiscount(subTotal);

        // return final total
        var finalTotal = subTotal - discount + shipping;
        return finalTotal;
    }
}