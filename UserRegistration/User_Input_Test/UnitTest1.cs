using System.Text.RegularExpressions;
using UserRegistration;

namespace TestUserInput
{
    public class Tests
    {
        Regex_User_Registration.RegularExpression  regularExpression = new Regex_User_Registration.RegularExpression();
        [Test]
        public void GivenFirstName_ReturnValidOrNot()
        {
            try
            {
                string name = "Nantha@";
                string Expected = regularExpression.FirstName(name);
                Assert.AreEqual(name, Expected);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid FirstName", e.Message);
            }
        }
        [Test]
        public void GivenLasttName_ReturnValidOrNot()
        {
            try
            {
                string name = "Shanmugam";
                string Expected = regularExpression.LastName(name);
                Assert.AreEqual(name, Expected);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid LastName", e.Message);
            }

        }
        [Test]
        public void GivenEmailId_ReturnTrue()
        {
            try
            {
                string Email = "s.nantha@gmail.com";
                Assert.IsTrue(regularExpression.Equals(Email));
                //string EmailId = (RegularExpression.email(Email));
                //Assert.AreEqual("Valid", EmailId);
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid Email Id", e.Message);
            }
        }
        [Test]
        public void GivenMobileNumber_ReturnTrue()
        {
            try
            {
                string mobileNumber = "91 9842778899";
                Assert.IsTrue(regularExpression.ContactNumber(mobileNumber));
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid Contact Number", e.Message);
            }
        }
        [Test]
        public void GivenPassword_ReturnTrue()
        {
            try
            {
                string password = "AbcdA@123Ac12";
                Assert.IsTrue(regularExpression.Password(password));
            }
            catch (CustomException e)
            {
                Assert.AreEqual("Invalid Contact Number", e.Message);
            }
        }
        [Test]
        public void CheckUserInputEmailToEmailRegex()
        {
            string[] InputId = System.IO.File.ReadAllLines(@"D:\.net\Regex-User-Rigistration-Problem\UserRegistration\UserRegistration\ValidMails.txt");
            foreach (string input in InputId)
            {
                
                string email = input.Equals(InputId);
                Assert.IsTrue(regularExpression.email(InputId));
                //Assert.AreEqual("Valid", email);
                // string result = regularExpression.email(inputId);
            }
        }
        [Test]
        public void CheckInvalidUserInputEmailToEmailRegex()
        {
            string[] inputId = System.IO.File.ReadAllLines(@"D:\.net\Regex-User-Rigistration-Problem\UserRegistration\UserRegistration\Invalid.txt");
            foreach (string input in inputId)
            {
                try
                {
                    string result = regularExpression.email(inputId);
                }
                catch (CustomException e)
                {
                    Assert.AreEqual("Invalid Email Id", e.Message);
                }

            }
        }
    }
}