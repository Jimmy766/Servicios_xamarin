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
    public partial class PantallaMensaje2 : ContentPage
    {
        public PantallaMensaje2()
        {
            InitializeComponent();
        }

        private async void irHome(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}