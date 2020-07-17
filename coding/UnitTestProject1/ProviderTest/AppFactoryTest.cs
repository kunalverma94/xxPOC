using ConsoleApp4;
using ConsoleApp4.Models.DTO.Request;
using ConsoleApp4.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class AppFactoryTest
    {

        [TestMethod]
        public void Should_RETURN_CapterraService()
        {
            //Arange
            var mocRequestContext = new Mock<IRequest>();
            mocRequestContext.Setup(a => a.Clients).Returns(Client.Capterra);

            //Act
            IBaseService result = AppFactory.AppFactoryInstance(mocRequestContext.Object);

            //assert
            Assert.IsInstanceOfType(result, typeof(CapterraService));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Should_RETURN_SoftwareAdvService()
        {
            //Arange
            var mocRequestContext = new Mock<IRequest>();
            mocRequestContext.Setup(a => a.Clients).Returns(Client.SoftwareAdvice);

            //Act
            IBaseService result = AppFactory.AppFactoryInstance(mocRequestContext.Object);

            //assert
            Assert.IsInstanceOfType(result, typeof(SoftwareAdviceService));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        [ExpectedException(typeof(NotImplementedException))]
        public void Should_RETURN_Error()
        {
            //Arange
            var mocRequestContext = new Mock<IRequest>();
            mocRequestContext.Setup(a => a.Clients).Returns(Client.INVALID);

            //Act
            IBaseService result = AppFactory.AppFactoryInstance(mocRequestContext.Object);

            //assert
            Assert.IsInstanceOfType(result, typeof(SoftwareAdviceService));
            Assert.IsNotNull(result);
        }
    }
}
