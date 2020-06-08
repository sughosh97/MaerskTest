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

        public Product(string v, double v1)
        {
            ProdName = v;
            Cost = v1;
        }

        public string ProdName { get; set; }
        public double Cost;


        private void GetData()
        {
            Console.WriteLine("Enter the Cost of product:{0}", ProdName);
            while (!double.TryParse(Console.ReadLine(), out Cost))
            {
                Console.Clear();
                Console.WriteLine("You entered an invalid number");
                Console.WriteLine("Enter the Cost of product:{0}", ProdName);
            }

        }
    }

}
