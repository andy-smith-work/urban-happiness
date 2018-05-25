using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyInfo.Controllers;
using System.Net;
using System.Web.Http.Results;
using CompanyInfo.Models;

namespace CompanyInfo.Tests
{
    [TestClass]
    public class PrivacyPolicyTests
    {

        private CompanyProperties properties = new CompanyProperties
        {
            PrivacyPolicyUrlEnglish = "http://english.example.com/privacy",
            PrivacyPolicyUrlFrench = "http://french.example.com/privacy",
        };



        [TestMethod]
        public void GetPrivacyPolicyUrl_NoParameters()
        {
            // Arrange
            PrivacyPolicyController controller = new PrivacyPolicyController(properties);

            // Act
            var actionResult = controller.GetPrivacyPolicyUrl();

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.PrivacyPolicyUrlEnglish, content);
        }


        [TestMethod]
        public void GetPrivacyPolicyUrl_English()
        {
            // Arrange
            PrivacyPolicyController controller = new PrivacyPolicyController(properties);

            // Act
            var actionResult = controller.GetPrivacyPolicyUrl("English");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.PrivacyPolicyUrlEnglish, content);
        }


        [TestMethod]
        public void GetPrivacyPolicyUrl_French()
        {
            // Arrange
            PrivacyPolicyController controller = new PrivacyPolicyController(properties);

            // Act
            var actionResult = controller.GetPrivacyPolicyUrl("French");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.PrivacyPolicyUrlFrench, content);
        }


        [TestMethod]
        public void GetPrivacyPolicyUrl_UnknownLanguage()
        {
            // Arrange
            PrivacyPolicyController controller = new PrivacyPolicyController(properties);

            // Act
            var actionResult = controller.GetPrivacyPolicyUrl("klingon");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.PrivacyPolicyUrlEnglish, content);
        }




    }
}
