using NUnit.Framework;
using NUnit.Core;

namespace SeleniumTests
{
    public class GoogleLogin
    {
        [Suite] public static TestSuite Suite
        {
            get
            {
                TestSuite suite = new TestSuite("GoogleLogin");
                suite.Add(new Untitled());
                suite.Add(new GoogleLogin());
                return suite;
            }
        }
    }
}
