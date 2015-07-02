//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Web.Http;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Sup;
//using Sup.Controllers;
//using Sup.Models;

//namespace Sup.Tests.Controllers
//{
//    [TestClass]
//    public class WayPointControllerTest
//    {
//        [TestMethod]
//        public void Get_Empty()
//        {
//            // Arrange
//            var controller = new WayPointController();

//            // Act
//            IEnumerable<WayPoint> result = controller.GetWayPoints(int.MinValue);

//            // Assert
//            Assert.IsNotNull(result);
//            Assert.AreEqual(0, result.Count());
//            //Assert.AreEqual("value2", result.ElementAt(1));
//        }

//        [TestMethod]
//        public void GetById_NotExisting()
//        {
//            // Arrange
//            var controller = new WayPointController();

//            // Act
//            var result = controller.Get(int.MaxValue);
//            var x = HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound;
//            // Assert
//            Assert.AreEqual(result.Statuscode, System.Net.HttpStatusCode.NotFound);
//        }

//        [TestMethod]
//        public void GetById_Found()
//        {
//            // Arrange
//            var controller = new WayPointController();

//            // Act
//            var result = controller.Get(1);

//            // Assert
//            Assert.AreEqual(result.Statuscode, System.Net.HttpStatusCode.Found);
//        }

//        [TestMethod]
//        public void GetByRouteId_Found()
//        {
//            // Arrange
//            var controller = new RouteController();

//            // Act
//            var result = controller.GetRoute(1);

//            // Assert
//            Assert.AreEqual(result.Statuscode, System.Net.HttpStatusCode.Found);
//        }

//        [TestMethod]
//        public void PostWayPoint()
//        {
//            // Arrange
//            var controller = new WayPointController();
//            var wayPoint = new WayPoint();
//            // Act
//            controller.Post(wayPoint);

//            // Assert
//        }

//        //[TestMethod]
//        //public void Put()
//        //{
//        //    // Arrange
//        //    ValuesController controller = new ValuesController();

//        //    // Act
//        //    controller.Put(5, "value");

//        //    // Assert
//        //}

//        [TestMethod]
//        public void Delete()
//        {
//            // Arrange
//            var controller = new WayPointController();

//            // Act
//            IHttpActionResult result = controller.Delete(5);

//            // Assert
//        }
//    }
//}
