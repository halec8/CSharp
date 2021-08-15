using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PayAndBonus.Tests

{

    using Pay_and_Bonus;

    [TestClass]

    public class PayAndBonusTests

    {

        [TestMethod]
        public void InputIsValid_ValidInputEntered_ReturnsTrue()
    {
        // Arrange

        var myPay = 100m; 
        var myBonus = 100m;


        PayAndBonus bonus = new PayAndBonus();
       
        // Act

        var result = bonus.InputIsValid(ref myPay, ref myBonus);
        


            // Assert

        Assert.IsTrue(result);
            
    }

        [TestMethod]
        public void InputIsValid_InvalidInputEntered_ReturnFalse()
        {
           
        }

        [TestMethod]

        public void InputIsValid_OnlyPayIsValid_ReturnErrorForBonus()
        {
            //Arrange

            //Act

            //Assert
        }

        public void InputIsValid_OnlyBonusIsValid_ReturnsErrorForPay()
        {

            //Arrange

            //Act

            //Assert

        }
    }
}
 