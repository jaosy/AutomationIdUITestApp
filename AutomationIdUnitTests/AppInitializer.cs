using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.UITest;
using AutomationIdUITestApp;

namespace AutomationIdUnitTests
{
    class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            if (platform == Platform.Android)
            {
                return ConfigureApp
                     .Android
                     .ApkFile("D:\\xamarin-candidate-apps\\AutomationIdUITestApp\\AutomationIdUnitTests\\com.companyname.automationiduitestapp.apk")
                     .StartApp();
            }

            return ConfigureApp
                .iOS
                .StartApp();
        }
    }
}
