using System;
using System.Collections.Generic;
using System.Text;

namespace MTest
{
    public class Order
    {
        public string ProductName;
        public int quantity;

        public Order(string prodName)
        {
            ProductName = prodName;
            getorder(prodName);
        }
        public Order(string prodName,int qty)
        {
            ProductName = prodName;
            quantity = qty;
            
        }
       

        private void getorder(string prodName)
        {
            Console.WriteLine("Enter the quantity of product:{0}", prodName);
            while (!int.TryParse(Console.ReadLine(), out quantity))
            {

                Console.Clear();
                Console.WriteLine("You entered an invalid number");
                Console.WriteLine("Enter the quantity of product:{0}", prodName);
            }
        }
    }
}
