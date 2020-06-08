using System;
using System.Collections.Generic;
using System.Text;

namespace MTest
{
    public class Product
    {


        public Product(string v)
        {
            ProdName = v;
            GetData();
        }

        public string ProdName { get; set; }
        public double Cost;
        public int Quantity;

        private void GetData()
        {

            Console.WriteLine("Enter the quantity of product:{0}", ProdName);
            while (!int.TryParse(Console.ReadLine(), out Quantity))
            {
                Console.Clear();
                Console.WriteLine("You entered an invalid number");
                Console.WriteLine("Enter the quantity of product:{0}", ProdName);
            }
            if (Quantity > 0)
            {

                while (!double.TryParse(Console.ReadLine(), out Cost))
                {
                    Console.Clear();
                    Console.WriteLine("You entered an invalid number");
                    Console.WriteLine("Enter the Cost of product:{0}", ProdName);
                }
                Console.WriteLine("Enter the Cost of product:{0}", ProdName);
                Cost = Convert.ToDouble(Console.ReadLine());
            }
        }
    }

}
