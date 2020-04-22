using NUnit.Framework;
using Prime.Services;
using Moq;

namespace Prime.UnitTests.Services
{
    [TestFixture]
    public class HomeControllerTest
    {
        private Mock<IGetDataRepository> mock;
        private HomeController home;

        [SetUp]
        public  void SetUp()
        {
            mock = new Mock<IGetDataRepository>();
            home = new HomeController(mock.Object);
        }

        [Test]  
        public void Test_Get_Data()  
        {                
            mock.Setup(p => p.GetNameById(1)).Returns("Jignesh");  
             
            string result = home.GetNameById(1);  
            
            Assert.AreEqual("Jignesh", result);  
        }
    }
}