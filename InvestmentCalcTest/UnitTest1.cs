using NUnit.Framework;
using P4InvestmentCalculator.Pages;

namespace InvestmentCalcTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CorrectFutureValue()
        {
            int years = 10;
            double principle = 10000;
            double interest = 0.10;
            int cmpPerYr = 2;
            double expectedValue = 26532.97;

            InvestmentCalc investmentCalc = new InvestmentCalc(principle, years, interest, cmpPerYr);


            Assert.AreEqual(expectedValue, investmentCalc.FutureValue, 0.01, "Future value not calculated correctly");
        }
    }
}