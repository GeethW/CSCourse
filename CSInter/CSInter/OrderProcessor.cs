using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSInter
{
    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalc;

        public OrderProcessor(IShippingCalculator shippingCalc)
        {
            _shippingCalc = shippingCalc;
        }

        public void Process(Order order)
        {
            if (order.IsShipped())
                throw new InvalidOperationException("Order is already shipped.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalc.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}
