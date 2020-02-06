using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Servicios.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MensajeCotizacion : ContentPage
    {
        public MensajeCotizacion()
        {
            InitializeComponent();
        }

        private async void irHome(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}