namespace Ex01.OrderPricingService;

public interface IDiscountService
{
    decimal GetDiscount(decimal subTotal);
}
