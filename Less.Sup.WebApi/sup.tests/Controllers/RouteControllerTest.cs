using System.Web.Http.Results;
using Less.Sup.WebApi.Controllers;
using Less.Sup.WebApi.Models;
using Less.Sup.WebApi.Tests.Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Less.Sup.WebApi.Tests.Controllers
{
    [TestClass]
    public class RouteControllerTest
    {
        [TestMethod]
        public void GetById_WithAKnownId_ShouldReturnThatRoute()
        {
            // Arrange
            var controller = new RouteController(new TestSupContext());

            // Act
            var actionResult = controller.Get(1);

            // Assert
            var response = actionResult as OkNegotiatedContentResult<Route>;
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<Route>));
            Assert.IsNotNull(response);
            Assert.AreEqual(1, response.Content.Id);
        }

        [TestMethod]
        public void GetById_WithAnUnknownId_ShouldReturnNotFound()
        {
            // Arrange
            var controller = new RouteController(new TestSupContext());

            // Act
            var actionResult = controller.Get(-1);

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof (NotFoundResult));
        }

    }
}