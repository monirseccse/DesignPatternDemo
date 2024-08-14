using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;
        
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void CheckOut(decimal amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }
}
