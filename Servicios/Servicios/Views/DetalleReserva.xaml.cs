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
    public partial class DetalleReserva : ContentPage
    {
        public DetalleReserva()
        {
            InitializeComponent();
        }

        private async void irMensaje(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PantallaMensaje2());
        }
    }
}