using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutomationIdUITestApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnGoToUsagePageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UsagePage());
        }

        private void OnToggleIsInUITestModeSwitch(object sender, ToggledEventArgs e)
        {
            UITestModeExtension.IsInUiTestMode = !UITestModeExtension.IsInUiTestMode;
        }
    }
}
