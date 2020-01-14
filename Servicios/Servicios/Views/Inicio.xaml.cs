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
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async Task LoginAsync(object sender, EventArgs e)
        {
            Login l = new Login();
            await Navigation.PushAsync(l);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Login l = new Login();
            await Navigation.PushAsync(l);
        }
        private async void irRecuperar(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new Recuperar());
        }

        private async void Registro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }
    }
}