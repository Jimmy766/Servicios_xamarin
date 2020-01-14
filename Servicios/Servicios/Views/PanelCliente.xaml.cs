using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Servicios.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PanelCliente : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }
        public PanelCliente()
        {
            InitializeComponent();
            //NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
            Items = new ObservableCollection<string>
            {
                "Notificaciones",
                "Mis proyectos",
                "Buscar servicios",
               //"Ver promociones",
                "Invitar Amigos",
                "Soporte contacto",
                "Configuracion",
                "Terminos y condiciones",
                "Cerrar sesion",
            };
            menu.ItemsSource = Items;
            
        }

        private async void menu_ItemSelected(object s, SelectedItemChangedEventArgs e)
        {
            //if (e.SelectedItem == null) return;
            await DisplayAlert("info",(s as string),"ok");
        }

        private async void irPerfil(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuTabs());
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}