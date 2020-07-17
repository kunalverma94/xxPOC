using ConsoleApp4.DataProvider;
using ConsoleApp4.DTO.Capterra;
using ConsoleApp4.DTO.SoftwareAdvice;
using ConsoleApp4.Providers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class DataServiceTest
    {

        [TestMethod]
        public void Should_RETUR_Products()
        {
            //Arange
            var mocRequestContext = new Mock<IDataRepository<CapterraDTO>>();
            var capterraDTOs = (new List<CapterraDTO>() {
            new CapterraDTO(){name="www",tags="xx,ww",twitter="" },
            new CapterraDTO(){name="www",tags="xx,ww",twitter="" }
            });
            mocRequestContext.Setup(a => a.GetProducts()).Returns(capterraDTOs);

            //Act
            var capterraService = new CapterraService(mocRequestContext.Object);
            var result = capterraService.GetProducts();

            //assert
            Assert.AreEqual(result.Count(), capterraDTOs.Count());
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Should_RETUR_Products_Software()
        {
            //Arange
            var mocRequestContext = new Mock<IDataRepository<SoftwareAdviceDTO>>();
            var SoftwareAWaDTOs = (new List<SoftwareAdviceDTO>() {
            new SoftwareAdviceDTO(){Title="www",Twitter="" },
            new SoftwareAdviceDTO(){Title="www" }
            });
            mocRequestContext.Setup(a => a.GetProducts()).Returns(SoftwareAWaDTOs);

            //Act
            var capterraService = new SoftwareAdviceService(mocRequestContext.Object);
            var result = capterraService.GetProducts();

            //assert
            Assert.AreEqual(result.Count(), SoftwareAWaDTOs.Count());
            Assert.IsNotNull(result);
        }
    }
}
