namespace DefaultNamespace;

public class PrinterCatridgesCalculation : PrinterCatridgesCalculationInterface
{
    private const int PricePerCartridge = 50; // made up price
    private const int MinimumOrderQuantity = 5;

    public decimal CalculatePrinterCatridges(int quantity)
    {
        if (quantity < MinimumOrderQuantity)
            //throw new ArgumentException("The minimum order quantity is 5.", nameof(quantity));

        var totalPrice = quantity * PricePerCartridge;

        if (quantity >= 100)
            totalPrice *= 0.8m;

        return totalPrice;
    }
}
