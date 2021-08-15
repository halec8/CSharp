using System;
using System.CodeDom;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HospitalCharges.UnitTest
{

    using HospitalChargesHale;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalcMiscCharges_WhenValidInputIsEntered_ReturnsExpected()
        {
            var myMeds = "100";
            var mySurgical = "100";
            var myLabs = "100";
            var myRehab = "100";

            HospitalCharges myCharges = new HospitalCharges();

            var result = myCharges.CalcMiscCharges(myMeds, mySurgical, myLabs, myRehab);
            var actual = 400;

            Assert.AreEqual(result, actual);
        }

        [TestMethod]

        public void CalcStayCharges_WhenValidInputIsEntered_ReturnExpected()
        {
            var days = "1";
            var myDays = 1;
            var DAILY_BASE = 350m;

            HospitalCharges myCharges = new HospitalCharges();

            var result = myCharges.CalcStayCharges(days);
            var actual = myDays * DAILY_BASE;

            Assert.AreEqual(result, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcMiscCharges_WhenInvalidInputIsEntered_ThrowException()
        {
            var myMeds = "Invalid Input";
            var mySurgical = "100";
            var myLabs = "100";
            var myRehab = "100";
            

            HospitalCharges myCharges = new HospitalCharges();

            var result = myCharges.CalcMiscCharges(myMeds, mySurgical, myLabs, myRehab);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CalcStayCharges_WhenInvalidInputIsEntered_ThrowException()

        {

            var days = "Invalid Input";

            HospitalCharges myCharges = new HospitalCharges();

            var result = myCharges.CalcStayCharges(days);
        }
    }
}
