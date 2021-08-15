using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Validation.Tests
{

    using ValidationTests;

    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void ValidateStudentId_WhenValidInputIsEntered_ReturnExpected()

        {
            var enteredStudentIdNumber = "900597212";

            Validation myValidation = new Validation();

            myValidation.studentIDTextBox.Text = enteredStudentIdNumber;

            var result = myValidation.ValidateStudentId(enteredStudentIdNumber);

            Assert.AreSame(enteredStudentIdNumber, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateStudentId_WhenInvalidInputIsEntered_ThrowException()
        {
            var enteredStudentIdNumber = "90059721D";

            Validation myValidation = new Validation();

            var result = myValidation.ValidateStudentId(enteredStudentIdNumber);

        }

        [TestMethod]

        public void ValidateFirstName_WhenValidInputIsEntered_ReturnExpected()
        {
            var enteredFirstName = "Cody";

            Validation myValidation = new Validation();

            myValidation.studentFirstNameTextBox.Text = enteredFirstName;

            var result = myValidation.ValidateFirstName(enteredFirstName);

            Assert.AreSame(enteredFirstName, result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateFirstName_WhenInvalidInputIsEntered_ThrowException()

        {
            var enteredFirst = "Cod1";

            Validation myValidation = new Validation();

            var result = myValidation.ValidateFirstName(enteredFirst);

        }

        [TestMethod]

        public void ValidateLastName_WhenValidInputIsEntered_ReturnExpected()
        {
            var enteredLastName = "Hale";

            Validation myValidation = new Validation();

            myValidation.studentLastNameTextBox.Text = enteredLastName;

            var result = myValidation.ValidateLastName(enteredLastName);

            Assert.AreSame(enteredLastName, result);
        }
    


    [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateLastName_WhenInvalidInputIsEntered_ThrowException()
        {

            var enteredLastName = "Hal3";

            Validation myValidation = new Validation();

            var result = myValidation.ValidateLastName(enteredLastName);

        }

        [TestMethod]

        public void ValidateClassCrn_WhenValidInputIsEntered_ReturnExpected()
        {
            var CrnNumber = "12345";

            Validation myValidation = new Validation();
            
            myValidation.classCRNTextBox.Text = CrnNumber;

            var result = myValidation.ValidateClassCrn(CrnNumber);

            Assert.AreSame(CrnNumber, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateClassCrn_WhenInvalidInputIsEntered_ThrowException()
        {

            var enteredClassCrn = "1234D";

            Validation myValidation = new Validation();

            myValidation.ValidateClassCrn(enteredClassCrn);

        }

        [TestMethod]

        public void ValidateClassCodeAndNumber_WhenValidInputIsEntered_ReturnExpected()
        {
            var EnteredClassCodeAndNumber = "CIS 125";

            Validation myValidation = new Validation();

            myValidation.classCodeAndNumberTextBox.Text = EnteredClassCodeAndNumber;

            var result = myValidation.ValidateClassCodeAndNumber(EnteredClassCodeAndNumber);

            Assert.AreSame(EnteredClassCodeAndNumber, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ValidateClassCodeAndNumber_WhenInvalidInputIsEntered_ThrowException()
        {
            var enteredClassCodeAndNumber = "123 CR1";

            Validation myValidation = new Validation();

            myValidation.ValidateClassCodeAndNumber(enteredClassCodeAndNumber);
        }
    }
}
