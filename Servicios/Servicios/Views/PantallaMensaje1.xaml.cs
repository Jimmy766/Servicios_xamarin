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
    public partial class PantallaMensaje1 : ContentPage
    {
        public PantallaMensaje1()
        {
            InitializeComponent();

        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(2000);
            await Navigation.PushAsync(new DetalleReserva());
        }
    }
}