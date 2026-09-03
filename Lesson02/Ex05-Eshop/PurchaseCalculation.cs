namespace Lesson02.Eshop;

public class PurchaseCalculation : IPurchaseCalculation
{
    private const decimal FirstDiscountThreshold = 300m;
    private const decimal SecondDiscountThreshold = 800m;
    private const decimal FirstDiscountRate = 0.05m;
    private const decimal SecondDiscountRate = 0.10m;

    public decimal CalculateDiscount(decimal purchaseAmount)
    {
        ValidatePurchaseAmount(purchaseAmount);

        var discountRate = purchaseAmount switch
        {
            > SecondDiscountThreshold => SecondDiscountRate,
            > FirstDiscountThreshold => FirstDiscountRate,
            _ => 0m
        };

        return decimal.Round(purchaseAmount * discountRate, 2, MidpointRounding.AwayFromZero);
    }

    public decimal CalculateTotal(decimal purchaseAmount)
    {
        ValidatePurchaseAmount(purchaseAmount);
        return purchaseAmount - CalculateDiscount(purchaseAmount);
    }

    private static void ValidatePurchaseAmount(decimal purchaseAmount)
    {
        if (purchaseAmount <= 0)
            throw new ArgumentOutOfRangeException(nameof(purchaseAmount), "Purchase amount must be greater than zero.");

        if (decimal.Round(purchaseAmount, 2) != purchaseAmount)
            throw new ArgumentException("Purchase amount must use whole øre only.", nameof(purchaseAmount));
    }
}
