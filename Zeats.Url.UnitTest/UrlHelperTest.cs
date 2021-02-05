using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zeats.Url.UnitTest
{
    [TestClass]
    public class UrlHelperTest
    {
        [TestMethod]
        public void IsValidUrl()
        {
            Assert.IsFalse(UrlHelper.IsValidUrl(null));
            Assert.IsFalse(UrlHelper.IsValidUrl(string.Empty));
            Assert.IsFalse(UrlHelper.IsValidUrl("lorem ipsum"));
            Assert.IsFalse(UrlHelper.IsValidUrl("google.com"));

            Assert.IsFalse(UrlHelper.IsValidUrl("ftp://www.google.com/"));

            Assert.IsTrue(UrlHelper.IsValidUrl("https://www.google.com/"));
            Assert.IsTrue(UrlHelper.IsValidUrl("http://www.google.com/"));
        }

        [TestMethod]
        public void IsValidHttpUrl()
        {
            Assert.IsFalse(UrlHelper.IsValidHttpUrl(null));
            Assert.IsFalse(UrlHelper.IsValidHttpUrl(string.Empty));
            Assert.IsFalse(UrlHelper.IsValidHttpUrl("lorem ipsum"));
            Assert.IsFalse(UrlHelper.IsValidHttpUrl("google.com"));

            Assert.IsFalse(UrlHelper.IsValidHttpUrl("ftp://www.google.com/"));
            Assert.IsFalse(UrlHelper.IsValidHttpUrl("https://www.google.com/"));

            Assert.IsTrue(UrlHelper.IsValidHttpUrl("http://www.google.com/"));
        }

        [TestMethod]
        public void IsValidHttpsUrl()
        {
            Assert.IsFalse(UrlHelper.IsValidHttpsUrl(null));
            Assert.IsFalse(UrlHelper.IsValidHttpsUrl(string.Empty));
            Assert.IsFalse(UrlHelper.IsValidHttpsUrl("lorem ipsum"));
            Assert.IsFalse(UrlHelper.IsValidHttpsUrl("google.com"));

            Assert.IsFalse(UrlHelper.IsValidHttpsUrl("ftp://www.google.com/"));
            Assert.IsFalse(UrlHelper.IsValidHttpsUrl("http://www.google.com/"));

            Assert.IsTrue(UrlHelper.IsValidHttpsUrl("https://www.google.com/"));
        }
    }
}