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
    public partial class PanelAdministrator : Shell
    {
#pragma warning disable CS0108 // 'PanelAdministrator.Items' oculta el miembro heredado 'Shell.Items'. Use la palabra clave new si su intención era ocultarlo.
        public ObservableCollection<string> Items { get; set; }
#pragma warning restore CS0108 // 'PanelAdministrator.Items' oculta el miembro heredado 'Shell.Items'. Use la palabra clave new si su intención era ocultarlo.
        public PanelAdministrator()
        {
            InitializeComponent();

            //NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);

            Items = new ObservableCollection<string>
            {
                "Notificaciones",
                "Ver proyectos",
                "Publicar promociones",
                "Administrar Usuarios",
                "Configuración",
                "Cerrar sesion",
            };
            //menu.ItemsSource = Items;

        }

        private async void menu_ItemSelected(object s, SelectedItemChangedEventArgs e)
        {
            //if (e.SelectedItem == null) return;
            await DisplayAlert("info", (s as string), "ok");
        }
  
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

#pragma warning disable CS1998 // El método asincrónico carece de operadores "await" y se ejecutará de forma sincrónica. Puede usar el operador 'await' para esperar llamadas API que no sean de bloqueo o 'await Task.Run(...)' para hacer tareas enlazadas a la CPU en un subproceso en segundo plano.
        private async void cerrarSession(object sender, EventArgs e)
#pragma warning restore CS1998 // El método asincrónico carece de operadores "await" y se ejecutará de forma sincrónica. Puede usar el operador 'await' para esperar llamadas API que no sean de bloqueo o 'await Task.Run(...)' para hacer tareas enlazadas a la CPU en un subproceso en segundo plano.
        {
            // await Navigation.PushAsync(new Inicio());

            Application.Current.MainPage = new Inicio();
        }
    }
}