
using Naxam.Controls.Forms;
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
    public partial class MenuTabs : BottomTabbedPage
    {
#pragma warning disable CS0414 // El campo 'MenuTabs.titulo' está asignado pero su valor nunca se usa
        private string titulo = "Mi Perfil";
#pragma warning restore CS0414 // El campo 'MenuTabs.titulo' está asignado pero su valor nunca se usa
        public MenuTabs()
        {
            InitializeComponent();
            
            Title = "Mi Perfil";
            

        }
       
    }
}