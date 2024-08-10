using InsuranceWebApplication.Utils;

namespace Test
{
    [TestClass]
    public class UtilTest
    {
        [TestMethod]
        public void TestToSha256()
        {
            string passwordHash = "5994471abb1112afcc18159f6cc74b4f511b9986da59b3caf5a9c173cacfc5";
            string result = Util.ToSha256("12345");
            Assert.AreEqual(passwordHash, result);
        }

        [TestMethod]
        public void TestIsValidEmail()
        {
            string validEmail = "carlosduarte.1@hotmail.com";
            string invalidEmail = "carlos duarte @ hotmail . com";
            Assert.IsTrue(Util.IsValidEmail(validEmail));
            Assert.IsFalse(Util.IsValidEmail(invalidEmail));
        }
    }
}
