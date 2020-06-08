using System;
using System.Collections.Generic;
using System.Text;

namespace MTest
{
    public class Discount
    {
        public double Calculate(List<Promotion> promotion, List<Order> order)
        {
            double total = 0;
            foreach (var o in order)
            {
                var pr = promotion.Find(i => i.ProductId.ProdName == o.ProductName);
                if (pr.Ptype == PromotionType.quantity)
                {
                    total += ((o.quantity / pr.quantity * pr.value) + (o.quantity % pr.quantity * pr.ProductId.Cost));
                }
                else if (pr.Ptype == PromotionType.combi)
                {
                    var com = order.Find(i => i.ProductName == pr.CombiProct.ProdName);
                    if (o.quantity == 0 || com.quantity == 0)
                    {
                        total += (o.quantity * pr.ProductId.Cost);
                    }
                    else if (o.quantity > com.quantity)
                    {
                        total += (com.quantity * pr.value) + ((o.quantity - com.quantity) * pr.ProductId.Cost);

                        order.Find(i => i.ProductName == pr.CombiProct.ProdName).quantity = 0;
                    }
                    else
                    {
                        total += (o.quantity * pr.value);

                        order.Find(i => i.ProductName == pr.CombiProct.ProdName).quantity = com.quantity - o.quantity;

                        order.Find(i => i.ProductName == pr.ProductId.ProdName).quantity = 0;
                    }


                }
                else
                {
                    //nothing
                }
            }
            return total;
        }
    }
}
