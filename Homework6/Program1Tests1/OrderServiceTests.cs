using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program1Tests1;
using System.IO;

namespace Program1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        private static readonly OrderService orderService = OrderService.GetInstance();

        private readonly static Random random = new Random();

        public static int MaxListSize { set; get; } = 4;

        [TestMethod()]
        public void GetInstanceTest()
        {
            Assert.IsNotNull(orderService);
            Assert.IsInstanceOfType(orderService, typeof(OrderService));
        }

        [TestMethod()]
        public void GetListTest()
        {
            var list1 = orderService.GetList();
            Assert.IsNotNull(list1);
            Assert.IsInstanceOfType(list1, typeof(List<Order>));
            list1.Add(Generator.GetOrder());
            var list2 = orderService.GetList();
            Assert.IsTrue(list1.Count == list2.Count + 1);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            var order = Generator.GetOrder();
            orderService.AddOrder(order);
            Assert.IsTrue(orderService.GetList().Contains(order));
        }

        [TestMethod()]
        public void RemoveOrderTest()
        {
            var list = orderService.GetList();
            if (list.Count==0)
            {
                var cnt = new Random().Next(1, MaxListSize);
                for (var i = 0; i < cnt; ++i)
                {
                    orderService.AddOrder(Generator.GetOrder());
                }
                list = orderService.GetList();
            }
            Assert.IsFalse(orderService.RemoveOrder(-1));
            Assert.IsFalse(orderService.RemoveOrder(list.Count));
            for (int i = 0, j = list.Count; i < j; ++i)
            {
                Assert.IsTrue((i < orderService.GetList().Count) == (orderService.RemoveOrder(i)));
            }
        }

        [TestMethod()]
        public void RemoveAllTest()
        {
            var order = Generator.GetOrder();
            orderService.AddOrder(order);
            Assert.IsTrue(orderService.RemoveAll(order2 => order2.Client.Equals(order.Client)));
        }

        [TestMethod()]
        public void FindAllTest()
        {
            orderService.ClearStatus();
            var order1 = Generator.GetOrder();
            var order2 = new Order(order1);
            while (order2.Client.Equals(order1.Client))
                order2.Client = Generator.GetClient();
            OrderDetails orderDetails;
            var order3 = new Order(order1);
            do
            {
                orderDetails = Generator.GetOrderDetails();
            } while (order3.List.Contains(orderDetails));
            order3.AddOrderDetails(orderDetails);

            orderService.AddOrder(order1);
            orderService.AddOrder(order2);
            orderService.AddOrder(order3);

            var find1 = orderService.FindAll(order => order.Client.Equals(order1.Client));
            Assert.IsTrue(find1.Count == 2);

            var find2 = orderService.FindAll(order => order.List.Count < order3.List.Count);
            Assert.IsTrue(find2.Count == 2);
        }

        [TestMethod()]
        public void ModifyOrderTest()
        {
            orderService.ClearStatus();
            for (var i = 0; i < MaxListSize; ++i)
                AddOrderTest();
            for (var i = 0; i < MaxListSize; ++i)
            {
                var order = Generator.GetOrder();
                Assert.IsTrue(orderService.ModifyOrder(random.Next(i), order));
            }
            Assert.IsFalse(orderService.ModifyOrder(-1, null));
            Assert.IsFalse(orderService.ModifyOrder(MaxListSize, null));
        }

        [TestMethod()]
        public void SaveStatusTest()
        {
            orderService.ClearStatus();
            for (var i = 0; i < MaxListSize; ++i)
                AddOrderTest();
            var list1 = orderService.GetList();
            orderService.SaveStatus();
            orderService.ReadStatus();
            var list2 = orderService.GetList();
            Assert.AreEqual(list1.Count, list2.Count);
            // TODO: List equals method test
            // Assert.AreEqual(list1, list2);
            for (var i = 0; i < list1.Count; ++i)
            {
                for (var j = 0; j < list1[i].List.Count; ++j)
                {
                    Assert.AreEqual(list1[i].List[j].Product, list2[i].List[j].Product);
                    Assert.AreEqual(list1[i].List[j].Cost, list2[i].List[j].Cost);
                    Assert.AreEqual(list1[i].List[j].Count, list2[i].List[j].Count);
                }
                Assert.AreEqual(list1[i].Client, list2[i].Client);
                Assert.AreEqual(list1[i].Cost, list2[i].Cost);
                Assert.AreEqual(list1[i].Id, list2[i].Id);
            }
        }

        [TestMethod()]
        public void ReadStatusTest()
        {
            SaveStatusTest();
        }

        [TestMethod()]
        public void ClearStatusTest()
        {
            AddOrderTest();
            orderService.ClearStatus();
            orderService.ClearStatus();
            using (var fileStream = new FileStream(orderService.SavingPath, FileMode.CreateNew)) ;
            orderService.ClearStatus();
        }
    }
}