
using System.Text.RegularExpressions;


namespace User_Input_Test
{

    public class Tests
    {
        UserRegistration.RegularExpression regularExpression = new UserRegistration.RegularExpression();

        [Test]
        public void GivenFirstName_ReturnValidOrNot()
        {
            string name = "Harini";
            string Expected = regularExpression.Name(name);
            Assert.AreEqual(name, Expected);
        }
        [Test]
        public void GivenLasttName_ReturnValidOrNot()
        {
            string name = "Lekkala";
            string Expected = regularExpression.Name(name);
            Assert.AreEqual(name, Expected);
        }
        [Test]
        public void GivenEmailId_ReturnTrue()
        {
            string inputEmail = "h.harinilekkala1997.com";
            Assert.IsFalse(regularExpression.email(inputEmail));
        }
        [Test]
        public void GivenMobileNumber_ReturnTrue()
        {
            string mobileNumber = "91 9842778899";
            Assert.IsTrue(regularExpression.CheckMobileNo(mobileNumber));
        }
        [Test]
        public void GivenPassword_ReturnTrue()
        {
            string password = "Hari@123";
            Assert.IsFalse(regularExpression.Password(password));
        }
        [Test]
        public void CheckValidUserInputEmailToEmailRegex()
        {
            string[] inputId = System.IO.File.ReadAllLines(@"D:\.net\Regex-User-Rigistration-Problem\UserRegistration\UserRegistration\ValidMails.txt");
            foreach (string input in inputId)
            {
                Assert.IsTrue(regularExpression.email(input));
            }
        }
        [Test]
        public void CheckInvalidUserInputEmailToEmailRegex()
        {
            string[] inputId = System.IO.File.ReadAllLines(@"D:\.net\Regex-User-Rigistration-Problem\UserRegistration\UserRegistration\Invalid.txt");
            foreach (string input in inputId)
            {
                Assert.IsFalse(regularExpression.email(input));
            }
        }
    }
}
