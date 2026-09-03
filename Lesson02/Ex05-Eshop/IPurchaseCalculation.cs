namespace Lesson02.Eshop;

public interface IPurchaseCalculation
{
    decimal CalculateDiscount(decimal purchaseAmount);

    decimal CalculateTotal(decimal purchaseAmount);
}
