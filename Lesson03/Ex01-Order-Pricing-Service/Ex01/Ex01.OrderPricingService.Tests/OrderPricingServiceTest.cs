using Ex01.OrderPricingService;
using JetBrains.Annotations;
using Xunit;
using Moq;

namespace Ex01.OrderPricingService.Tests;

[TestSubject(typeof(OrderPricingService))]
public class OrderPricingServiceTest
{

    [Fact]
    public void METHOD()
    {
        
    }
    /*
     [Fact]
       public void CalculateTotal_ReturnsSubtotalMinusDiscountPlusShipping()
       {
           var discountService = new Mock<IDiscountService>();
           discountService
               .Setup(service => service.GetDiscount(1000m))
               .Returns(100m);

           var shippingService = new Mock<IShippingService>();
           shippingService
               .Setup(service => service.GetShippingCosts("DK", 1000m))
               .Returns(49m);

           var sut = new OrderPricingService(
               discountService.Object,
               shippingService.Object);

           var result = sut.CalculateTotal("DK", 1000m);

           Assert.Equal(949m, result);
       }
     
     */
}