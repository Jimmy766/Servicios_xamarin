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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }

        private async void registro(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registro());
        }

        private async void entrar(object sender, EventArgs e)
        {
            

            if (usuario.Text == null)

                await DisplayAlert("Error", "Numero de telefono no puede estar vacio", "ok");
            else
            if (password.Text == null)
                await DisplayAlert("Error", "Debe ingresar una contraseña", "ok");
            else
            if (usuario.Text != "1234567" && usuario.Text != "123456" && usuario.Text != "12345")
                await DisplayAlert("Error", "Numero de telefono incorrecto!", "ok");
            else
            if (password.Text != "prueba")
                await DisplayAlert("Error", "Contraseña incorrecta!", "ok");
            else
            if (usuario.Text == "1234567")

                
            Application.Current.MainPage = new PanelCliente();
            else
            if (usuario.Text == "123456")
                Application.Current.MainPage = new PanelAdministrator();
            else
                Application.Current.MainPage = new PanelContratista();

        }
    }
}