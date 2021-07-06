using System;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using AutomationIdUITestApp;

namespace AutomationIdUITestApp
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class UITests
    {
        IApp app;
        Platform platform;

        static readonly Func<AppQuery, AppQuery> Button = c => c.Marked("clickMeButton");
        static readonly Func<AppQuery, AppQuery> ClickedLabel = c => c.Marked("clickButtonLabel");


        public UITests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            UITestModeExtension.IsInUiTestMode = true;
            app = AutomationIdUnitTests.AppInitializer.StartApp(platform);
        }

        [Test]
        public void TestMethod1()
        {
#if DEBUG
            // The following method will trap the UI test into REPL tool window CLI
            app.Repl();
            // if you want to quit the REPL tool, type quit at the REPL prompt
#endif
            app.Repl();
            // Arrange - Nothing to do because the queries have already been initialized.
            AppResult[] result = app.Query(Button);

            // Act
            app.Tap(Button);

            // Assert
            result = app.Query(ClickedLabel);
            Assert.IsTrue(result.Any(r => r.Text == "I was clicked!"));
        }
    }
}
