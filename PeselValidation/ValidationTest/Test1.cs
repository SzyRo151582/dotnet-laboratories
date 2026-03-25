using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeselValidation;
using System;


namespace ValidationTest
{
    [TestClass]
    public class ValidatorTest
    {
        PESELValidator validator1, validator2, validator3, validator4, validator5, validator6, validator7, validator8;

        [TestInitialize]
        public void InitializeValidation()
        {
            validator1 = new PESELValidator();
            validator1.LoadPesel("123");
            validator2 = new PESELValidator();
            validator2.LoadPesel("71230522861");
            validator3 = new PESELValidator();
            validator3.LoadPesel("02070803628");
            validator4 = new PESELValidator();
            validator4.LoadPesel("24881622793");
            validator5 = new PESELValidator();
            validator5.LoadPesel("05112589751");
            validator6 = new PESELValidator();
            validator6.LoadPesel("19311285943");
            validator7 = new PESELValidator();
            validator7.LoadPesel("00292705892");
            validator8 = new PESELValidator();
            validator8.LoadPesel("18384590031");
        }

        [TestMethod]
        public void TestCheckWrongNumber()
        {
            bool result = validator1.CheckPesel();
            Assert.IsTrue(result, "The PESEL number you have entered is too long or too short. A PESEL number always consists of 11 digits.");
        }

        [TestMethod]
        public void TestCheckValidPeselLenghtTest()
        {
            bool result = validator2.CheckPesel();
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestCalculateChecksumEqualEight()
        {
            Assert.AreEqual(8, validator3.CheckSum());
        }
        [TestMethod]
        public void TestCalculateChecksumEqualFive()
        {
            Assert.AreEqual(5, validator4.CheckSum(), 0, "This personal identification number has a checksum of three.");
        }

        [TestMethod]
        public void TestCheckPersonBornInXXCentury()
        {
            Assert.AreEqual("25.11.1905", validator5.BirthDate());
        }

        [TestMethod]
        public void TestCheckPersonBornInXXICentury()
        {
            Assert.AreEqual("12.11.2019", validator6.BirthDate());
        }

        [TestMethod]
        public void TestCheckGenderMale()
        {
            Assert.AreEqual("Male", validator7.Gender());
        }

        [TestMethod]
        public void TestCheckGenderFemale()
        {
            Assert.AreEqual("Female", validator8.Gender(), "According to this personal identification number, the person is a man.");
        }
    }
}
