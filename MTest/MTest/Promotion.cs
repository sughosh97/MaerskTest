using System;
using System.Collections.Generic;
using System.Text;

namespace MTest
{
   public enum PromotionType
    {
        combi = 0,
        quantity = 1

    }
    public class Promotion
    {
        public Product ProductId;
        public PromotionType Ptype;
        public int quantity;
        public Product CombiProct;
        public double value;

        public Promotion(Product Pname, PromotionType pt, int qty, Product Cp, double v3)
        {
            ProductId = Pname;
            Ptype = pt;
            if (pt == PromotionType.quantity)
            {
                quantity = qty;
            }
            else
            {
                CombiProct = Cp;
            }

            value = v3;
        }
    }
}
