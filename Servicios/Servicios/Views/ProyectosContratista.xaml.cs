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
    public partial class ProyectosContratista : ContentPage
    {
        public ProyectosContratista()
        {
            InitializeComponent();
        }

        private async void Button_Pressed(object sender, EventArgs e)
        {
            if (valor.Text == null)
                await DisplayAlert("Error", "Debe introducir un valor!", "ok");
            else 
            await Navigation.PushAsync(new MensajeCotizacion());
        }
    }
}