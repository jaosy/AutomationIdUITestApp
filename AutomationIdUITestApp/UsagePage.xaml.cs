using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AutomationIdUITestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsagePage : ContentPage
    {
        public UsagePage()
        {
            InitializeComponent();
        }

        async void OnClickMeButtonClicked(object sender, EventArgs e)
        {
            clickButtonLabel.Text = "I was clicked!";
        }
    }
}