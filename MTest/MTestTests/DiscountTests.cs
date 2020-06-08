using Microsoft.VisualStudio.TestTools.UnitTesting;
using MTest;
using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MTest.Tests
{
    [TestClass()]
    public class DiscountTests
    {

        Product pa; Product pb; Product pc; Product pd;
        List<Promotion> promotion = new List<Promotion>();
        [TestInitialize]
        public void iniMembers()
        {

            pa = new Product("A", 50);
            pb = new Product("B", 30);
            pc = new Product("C", 20);
            pd = new Product("D", 15);
            
            promotion.Add(new Promotion(pa, PromotionType.quantity, 3, null, 130));
            promotion.Add(new Promotion(pb, PromotionType.quantity, 2, null, 45));
            promotion.Add(new Promotion(pc, PromotionType.combi, 0, pd, 30));
            promotion.Add(new Promotion(pd, PromotionType.combi, 0, pc, 40));
        }

        [TestMethod()]
        [DataRow(5, 5, 1, 0, 370)]
        [DataRow(3, 5, 1, 1, 280)]
        [DataRow(1, 1, 1, 0, 100)]
        public void CalculateTest(int qa, int qb, int qc,int qd,double exp)
        {
            List<Order> order = new List<Order>();

            order.Add(new Order(pa.ProdName,qa));
            order.Add(new Order(pb.ProdName,qb));
            order.Add(new Order(pc.ProdName,qc));
            order.Add(new Order(pd.ProdName,qd));
            Discount discount = new Discount();

            double total = discount.Calculate(promotion, order);
            Assert.AreEqual(total, exp);

        }
    }
}