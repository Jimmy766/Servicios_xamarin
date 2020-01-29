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
    public partial class PerfilCliente : ContentPage
    {
        public PerfilCliente()
        {
            InitializeComponent();
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            (App.Current.MainPage as Shell).FlyoutIsPresented = false;
            NavigationPage.SetHasBackButton(this, false);
        }
        private void mostrarPanel(object sender, EventArgs e)
        {
            (App.Current.MainPage as Shell).FlyoutIsPresented = true;
        }
    }
}