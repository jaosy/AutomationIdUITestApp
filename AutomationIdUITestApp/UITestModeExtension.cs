using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Xaml;
using Xamarin.Forms;

namespace AutomationIdUITestApp
{
    public class UITestModeExtension : IMarkupExtension
    {
        public string AutomationId { get; set; }
        public static bool IsInUiTestMode { get; set; } = false;

        public string ProvideValue(IServiceProvider serviceProvider)
        {
            if (IsInUiTestMode)
                return AutomationId;
            else
                return null;
        }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            if (IsInUiTestMode)
                return AutomationId;
            else
                return null;
        }
    }
}
