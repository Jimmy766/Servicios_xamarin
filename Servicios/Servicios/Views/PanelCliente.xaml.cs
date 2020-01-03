﻿using System;
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
            NavigationPage.SetHasNavigationBar(this, false);
            Items = new ObservableCollection<string>
            {
                "Notificaciones",
                "Mis proyectos",
                "Buscar servicios",
                "Ver promociones",
                "Invitar Amigos",
                "Soporte contacto",
                "Configuracion",
                "Terminos y condiciones",
                "Cerrar sesion",
            };
            menu.ItemsSource = Items;
        }

        private void menu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           
        }
    }
}