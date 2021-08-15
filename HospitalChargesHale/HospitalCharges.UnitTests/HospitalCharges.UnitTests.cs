using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HospitalCharges.UnitTests
{
    [TestClass]

    public class HospitalCharges

    {
        [TestMethod]
        public void CalcMiscCharges_ValidInputEntered_ReturnsExpectedValue()
    {
        //arrange
        decimal myMeds = 5m;
        decimal mySurgical = 100m;
        decimal myLab = 15m;
        decimal myRehab = 50m;

        HospitalCharges myCharges = new HospitalCharges();


        //act

        //assert

    }
    }
}
