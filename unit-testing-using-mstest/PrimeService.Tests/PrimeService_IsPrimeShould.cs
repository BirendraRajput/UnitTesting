using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {

        //https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-mstest
        
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        }

        // [TestMethod]
        // public void IsPrime_InputIs1_ReturnFalse()
        // {
        //     var result = _primeService.IsPrime(1);

        //     Assert.IsFalse(result, "1 should not be prime");
        // }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void IsPrime_InputIs1_ReturnFalse(int value)
        {
            var result =  _primeService.IsPrime(value);

            Assert.IsFalse(result,$"{value} should not ne prime");
        }

    }
}