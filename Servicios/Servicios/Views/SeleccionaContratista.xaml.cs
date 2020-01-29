using Servicios.Models;
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
    
    public partial class SeleccionaContratista : ContentPage
    {
        public ObservableCollection<Item> datos { get; set; }
        public SeleccionaContratista()
        {
            InitializeComponent();
            datos = new ObservableCollection<Item>();
            datos.Add(new Item());
            datos.Add(new Item());
            datos.Add(new Item());
            datos.Add(new Item());
            datos.Add(new Item());
            datos.Add(new Item());
            datos.Add(new Item());
            datos.Add(new Item());
            datos.Add(new Item());
            BindingContext = this;
        }

        private async void irEnviaDetalleContratista(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EnviaDetalleContratista());
        }
    }
}