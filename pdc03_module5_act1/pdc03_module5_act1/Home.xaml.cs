using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pdc03_module5_act1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        private async void OpenActivity01(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity01());
        }

        private async void OpenActivity02(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity02());
        }

        private async void OpenActivity03(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity03());
        }
        private async void OpenActivity04(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new activity04());
        }
    }
}