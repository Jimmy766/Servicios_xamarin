﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Servicios.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeleccionaSubcategoria : ContentPage
    {
        public SeleccionaSubcategoria()
        {
            InitializeComponent();
        }
        private async void irSeleccionFecha(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SeleccionaFecha());

        }
    }
}