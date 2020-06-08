using System;
using System.Collections.Generic;

namespace MTest
{
    public class Program
    {
        public static void Main(string[] args)
        {

            List<Product> product = new List<Product>();
            
            Product pa = new Product("A", 50);
            Product pb = new Product("B", 30);
            Product pc = new Product("C", 20);
            Product pd = new Product("D", 15);

            List<Promotion> promotion = new List<Promotion>();
            promotion.Add(new Promotion(pa, PromotionType.quantity, 3, null, 130));
            promotion.Add(new Promotion(pb, PromotionType.quantity, 2, null, 45));
            promotion.Add(new Promotion(pc, PromotionType.combi, 0, pd, 30));
            promotion.Add(new Promotion(pd, PromotionType.combi, 0, pc, 40));

            List<Order> order = new List<Order>();
            order.Add(new Order(pa.ProdName));
            order.Add(new Order(pb.ProdName));
            order.Add(new Order(pc.ProdName));
            order.Add(new Order(pd.ProdName));

            Discount discount = new Discount();
            
            double total =discount.Calculate(promotion, order);
            
            Console.WriteLine(total);
            Console.ReadLine();
        }

    }


}


