using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ShoppingCartLib.Model;

namespace ShoppingCartLibTest
{
    [TestClass]
    public class CustomerTest
    {
        Customer customer = new Customer(400, "Shivam");
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual<int>(customer.OrderCount, 0);
            Order order = new Order(1001, DateTime.Today);
            order.AddItem(new LineItem(504, new Product(101, "Laptop", 30000, 0.5f), 1));
            customer.AddOrder(order);
            Assert.AreEqual<int>(1, customer.OrderCount);
        }
        [TestMethod]
        public void TestCustomerDetails()
        {
            Assert.AreEqual<int>(400, customer.Id);
            Assert.AreEqual<string>("Shivam", customer.Nmae);
        }
    }
}
