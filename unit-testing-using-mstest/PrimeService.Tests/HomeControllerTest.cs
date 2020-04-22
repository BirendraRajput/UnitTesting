using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;
using Moq;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class HomeControllerTest
    {
        private Mock<IGetDataRepository> mock;
        private HomeController home;
        public HomeControllerTest()
        {
            mock = new Mock<IGetDataRepository>();
            home = new HomeController(mock.Object);
        }

        [TestMethod]  
        public void Test_Get_Data()  
        {                
            mock.Setup(p => p.GetNameById(1)).Returns("Jignesh");  
             
            string result = home.GetNameById(1);  
            
            Assert.AreEqual("Jignesh", result);  
        }
    }
}