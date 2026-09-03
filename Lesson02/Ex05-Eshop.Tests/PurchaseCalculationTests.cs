using Lesson02.Eshop;

namespace Lesson02.Eshop.Tests;

public class PurchaseCalculationTests
{
    private readonly PurchaseCalculation _calculation = new();

    [Theory]
    [InlineData(0)] // Invalid lower boundary
    public void CalculateDiscount_InvalidPurchaseAmount_ThrowsArgumentOutOfRangeException(decimal purchaseAmount)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => _calculation.CalculateDiscount(purchaseAmount));
    }

    [Theory]
    [InlineData(1, 0)] // Valid lower boundaries
    [InlineData(150, 0)]
    [InlineData(299.01, 0)] // Valid upper boundaries
    [InlineData(300, 0)] // Valid upper boundaries
    [InlineData(300.01, 15)] // Invalid upper boundary
    [InlineData(450, 22.50)]
    [InlineData(799.01, 39.95)] // Valid upper boundaries
    [InlineData(800, 40)] // Valid upper boundaries
    [InlineData(800.01, 80)] // Invalid upper boundary
    [InlineData(950, 95)]
    public void CalculateDiscount_ValidPurchaseAmount_ReturnsExpectedDiscount(
        decimal purchaseAmount,
        decimal expectedDiscount)
    {
        Assert.Equal(expectedDiscount, _calculation.CalculateDiscount(purchaseAmount));
    }
}
