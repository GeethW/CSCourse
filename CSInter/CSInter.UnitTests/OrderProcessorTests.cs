using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSInter.UnitTest
{
    [TestClass]
    public class OrderProcessorTests
    {
        //METHODNAME_CONDITION_EXPECTATION

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsAlreadyShipped_ThrowAnException()
        {
            var orderProc = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order()
            {
                Shipment = new Shipment()
            };
        }

        public void Process_OrderISNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
        {
            var orderProc = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProc.Process(order);

            Assert.IsTrue(order.IsShipped());
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}
