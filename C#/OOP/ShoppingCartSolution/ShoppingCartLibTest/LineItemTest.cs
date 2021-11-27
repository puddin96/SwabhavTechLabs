using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingCartLib.Model;

namespace ShoppingCartLibTest
{
    [TestClass]
    public class LineItemTest
    {
        [TestMethod]
        public void LineItemTest1()
        {
            LineItem lineItem = new LineItem(504, new Product(101, "Laptop", 30000, 0.5f), 1);
            Assert.IsTrue(lineItem.Quantity == 1);
            Assert.AreEqual<Product>(lineItem.Product, new Product(101, "Laptop", 30000, 0.5f));
        }

        [TestMethod]
        public void TestDiscountedPrice()
        {
            LineItem lineItem = new LineItem(504, new Product(101, "Laptop", 15000, 50f), 3);
            Assert.AreEqual<double>(lineItem.Calculate(), 22500);
        }
    }
}
