namespace Lesson02.Eshop.Tests;

public class DiscountCalculation : IDiscountCalculation
{
    private const decimal MinWidth = 30m;
    private const decimal MaxWidth = 100m;
    private const decimal MinHeight = 30m;
    private const decimal MaxHeight = 60m;
    private const decimal MinPrice = 3000m;
    private const decimal MaxPrice = 3500m;

    public decimal CalculateDiscount(decimal height, decimal width)
    {
        ValidateDimensions(height, width);

        var area = height * width;
        if (area > 1600m)
            return MaxPrice;

        return MinPrice;
    }

    private static void ValidateDimensions(decimal height, decimal width)
    {
        if (height < MinHeight || height > MaxHeight)
            throw new ArgumentOutOfRangeException(nameof(height), "Height must be between 30 and 60 cm.");

        if (width < MinWidth || width > MaxWidth)
            throw new ArgumentOutOfRangeException(nameof(width), "Width must be between 30 and 100 cm.");
    }
}
