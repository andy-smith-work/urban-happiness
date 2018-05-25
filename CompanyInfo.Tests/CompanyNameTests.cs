using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CompanyInfo.Controllers;
using System.Net;
using System.Web.Http.Results;
using CompanyInfo.Models;

namespace CompanyInfo.Tests
{
    [TestClass]
    public class CompanyNameTests
    {

        private CompanyProperties properties = new CompanyProperties
        {
            CorporateHomepageUrlEnglish = "http://english.example.com",
            CorporateHomepageUrlFrench = "http://french.example.com",
            LegalCompanyNameEnglish = "Full Legal Name English, Inc.",
            LegalCompanyNameFrench = "Full Legal Name French, Inc.",
            PrivacyPolicyUrlEnglish = "http://english.example.com/privacy",
            PrivacyPolicyUrlFrench = "http://french.example.com/privacy",
            SimpleCompanyNameEnglish = "Simple Name English",
            SimpleCompanyNameFrench = "Simple Name French",
            StandardCompanyNameEnglish = "Standard Name English",
            StandardCompanyNameFrench = "Standard Name French"
        };



        [TestMethod]
        public void GetName_NoParameters()
        {
            // Arrange
            CompanyNameController controller = new CompanyNameController(properties);

            // Act
            var actionResult = controller.GetName();

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.StandardCompanyNameEnglish, content);
        }


        [TestMethod]
        public void GetName_English()
        {
            // Arrange
            CompanyNameController controller = new CompanyNameController(properties);

            // Act
            var actionResult = controller.GetName("English");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.StandardCompanyNameEnglish, content);
        }


        [TestMethod]
        public void GetName_French()
        {
            // Arrange
            CompanyNameController controller = new CompanyNameController(properties);

            // Act
            var actionResult = controller.GetName("French");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.StandardCompanyNameFrench, content);
        }


        [TestMethod]
        public void GetName_UnknownLanguage()
        {
            // Arrange
            CompanyNameController controller = new CompanyNameController(properties);

            // Act
            var actionResult = controller.GetName("klingon");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.StandardCompanyNameEnglish, content);
        }



        [TestMethod]
        public void GetLegalName_NoParameters()
        {
            // Arrange
            CompanyNameController controller = new CompanyNameController(properties);

            // Act
            var actionResult = controller.GetLegalName();

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.LegalCompanyNameEnglish, content);
        }


        [TestMethod]
        public void GetLegalName_English()
        {
            // Arrange
            CompanyNameController controller = new CompanyNameController(properties);

            // Act
            var actionResult = controller.GetLegalName("English");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.LegalCompanyNameEnglish, content);
        }


        [TestMethod]
        public void GetLegalName_French()
        {
            // Arrange
            CompanyNameController controller = new CompanyNameController(properties);

            // Act
            var actionResult = controller.GetLegalName("French");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.LegalCompanyNameFrench, content);
        }


        [TestMethod]
        public void GetLegalName_UnknownLanguage()
        {
            // Arrange
            CompanyNameController controller = new CompanyNameController(properties);

            // Act
            var actionResult = controller.GetLegalName("klingon");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.LegalCompanyNameEnglish, content);
        }



        [TestMethod]
        public void GetSimpleName_NoParameters()
        {
            // Arrange
            CompanyNameController controller = new CompanyNameController(properties);

            // Act
            var actionResult = controller.GetSimpleName();

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.SimpleCompanyNameEnglish, content);
        }


        [TestMethod]
        public void GetSimpleName_English()
        {
            // Arrange
            CompanyNameController controller = new CompanyNameController(properties);

            // Act
            var actionResult = controller.GetSimpleName("English");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.SimpleCompanyNameEnglish, content);
        }


        [TestMethod]
        public void GetSimpleName_French()
        {
            // Arrange
            CompanyNameController controller = new CompanyNameController(properties);

            // Act
            var actionResult = controller.GetSimpleName("French");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.SimpleCompanyNameFrench, content);
        }


        [TestMethod]
        public void GetSimpleName_UnknownLanguage()
        {
            // Arrange
            CompanyNameController controller = new CompanyNameController(properties);

            // Act
            var actionResult = controller.GetSimpleName("klingon");

            // Assert
            Assert.IsInstanceOfType(actionResult, typeof(OkNegotiatedContentResult<string>));
            string content = ((OkNegotiatedContentResult<string>) actionResult).Content;
            Assert.AreEqual(properties.SimpleCompanyNameEnglish, content);
        }

    }
}
