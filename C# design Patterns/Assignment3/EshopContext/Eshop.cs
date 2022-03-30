using Assignment3.Models;
using Assignment3.PaymentMethodStrategy;
using Assignment3.VariationStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.EshopContext
{
    internal class Eshop
    {
        private IEnumerable<IVariationStrategy> variations;
        private IPaymentMethodStrategy paymentMethod;

        public void SetPaymentMethod(IPaymentMethodStrategy method)
        {

            paymentMethod = method;
        }


        public void SetVariation(IEnumerable<IVariationStrategy> variationStrategies)
        {

            variations=variationStrategies;
        }
        public void CalculateCost(Tshirt tshirt)
        {
            foreach (var variation in variations)
            {
                variation.Cost(tshirt);
            }
            Console.WriteLine($"T-Shirt final price is {tshirt.Price} euros");
        }
        public void PayTshirt(decimal price)
        {
           

            if (paymentMethod.Pay(price))
            {
                Console.WriteLine("Transaction was succesful");
            }
            else
            {
                Console.WriteLine("Transaction aborded");
            }

        }

        public void Discount(Tshirt tshirt,decimal?perecntage)
        {
            paymentMethod.Discount(tshirt,perecntage);
        }
    }
}
