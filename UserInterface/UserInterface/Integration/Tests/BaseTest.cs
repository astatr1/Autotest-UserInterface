using Aquality.Selenium.Browsers;
using UserInterface.Framework.Models;
using UserInterface.Framework.Utils;
using UserInterface.Integration.Utils;

namespace Userinterface.Integration.Tests
{
    [TestFixture]
    public class BaseTest
    {
        protected Config config;
        protected TestData testData;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var configPath = new string[] { "Resources", "config.json" };
            config = JsonFileReader.ReadFromFile<Config>(PathHelper.GetFullPath(configPath));
            testData = JsonFileReader.ReadFromFile<TestData>(PathHelper.GetFullPath(config.TestDataPath));
        }

        [SetUp]
        public void Setup()
        {
            AqualityServices.Browser.Maximize();
            AqualityServices.Browser.GoTo(config.BaseUrl);
        }

        [TearDown]
        public void TearDown()
        {
            AqualityServices.Browser.Quit();
        }
    }
}
