using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NHibCsSample.Generated.ManagerObjects;
using NHibCsSample.Generated.BusinessObjects;
using NHibCsSample.Generated.Base;

namespace NHibCsSample.Generated.UnitTests
{
	[TestFixture]
    public partial class OrderStatusTests : UNuitTestBase
    {
        protected IOrderStatusManager manager;
		
		public OrderStatusTests()
        {
            manager = managerFactory.GetOrderStatusManager();
        }
		
		protected OrderStatus CreateNewOrderStatus()
		{
			OrderStatus entity = new OrderStatus();
			
			
			entity.OrderId = 94;
			entity.LineNum = 79;
			entity.Timestamp = DateTime.Now;
			entity.Status = "T";
			
			return entity;
		}
		protected OrderStatus GetFirstOrderStatus()
        {
            IList<OrderStatus> entityList = manager.GetAll(1);
            if (entityList.Count == 0)
                Assert.Fail("All tables must have at least one row for unit tests to succeed.");
            return entityList[0];
        }
		
		[Test]
        public void Create()
        {
            try
            {
				OrderStatus entity = CreateNewOrderStatus();
				
                object result = manager.Save(entity);

                Assert.IsNotNull(result);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
        [Test]
        public void Read()
        {
            try
            {
                OrderStatus entityA = CreateNewOrderStatus();
				manager.Save(entityA);

                OrderStatus entityB = manager.GetById(entityA.Id);

                Assert.AreEqual(entityA, entityB);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
		[Test]
		public void Update()
        {
            try
            {
                OrderStatus entityA = GetFirstOrderStatus();
				
				entityA.Timestamp = DateTime.Now;
				
				manager.Update(entityA);

                OrderStatus entityB = manager.GetById(entityA.Id);

                Assert.AreEqual(entityA.OrderId, entityB.OrderId);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
        [Test]
        public void Delete()
        {
            try
            {
                OrderStatus entity = GetFirstOrderStatus();
				
                manager.Delete(entity);

                entity = manager.GetById(entity.Id);
                Assert.IsNull(entity);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
	}
}
