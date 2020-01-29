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
    public partial class EnviaDetalleContratista : ContentPage
    {
        public EnviaDetalleContratista()
        {
            InitializeComponent();
        }

        private async void irMensaje(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PantallaMensaje1());
        }
    }
}