using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyInfo.Controllers;
using System.Web.Http.Results;
using CompanyInfo.Models;

namespace CompanyInfo.Tests
{
    [TestClass]
    public class HomepageUrlTests
    {

        private CompanyProperties properties = new CompanyProperties
        {
            CorporateHomepageUrlEnglish = "http://english.example.com",
            CorporateHomepageUrlFrench = "http://french.example.com",
        };



        [TestMethod]
        public void GetCorporateUrl_NoParameters()
        {
            // Arrange
            HomepageUrlController controller = new HomepageUrlController(properties);

            // Act
            var actionResult = controller.GetCorporateUrl();

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.CorporateHomepageUrlEnglish, content);
        }


        [TestMethod]
        public void GetCorporateUrl_English()
        {
            // Arrange
            HomepageUrlController controller = new HomepageUrlController(properties);

            // Act
            var actionResult = controller.GetCorporateUrl("English");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.CorporateHomepageUrlEnglish, content);
        }


        [TestMethod]
        public void GetCorporateUrl_French()
        {
            // Arrange
            HomepageUrlController controller = new HomepageUrlController(properties);

            // Act
            var actionResult = controller.GetCorporateUrl("French");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.CorporateHomepageUrlFrench, content);
        }


        [TestMethod]
        public void GetCorporateUrl_UnknownLanguage()
        {
            // Arrange
            HomepageUrlController controller = new HomepageUrlController(properties);

            // Act
            var actionResult = controller.GetCorporateUrl("klingon");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.CorporateHomepageUrlEnglish, content);
        }




    }
}
