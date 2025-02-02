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
    public partial class SeleccionaFecha : ContentPage
    {
        public SeleccionaFecha()
        {
            InitializeComponent();
            calendario.StartDate = DateTime.Now;
            calendario.SpecialDates.Add(new XamForms.Controls.SpecialDate(DateTime.Now.AddDays(1))
            {
                Selectable = false,
                TextColor = Color.OrangeRed,
                BackgroundColor = Color.Gray

            }); 
            calendario.SpecialDates.Add(new XamForms.Controls.SpecialDate(DateTime.Now.AddDays(5))
            {
                Selectable = false,
                TextColor=Color.OrangeRed,
                BackgroundColor = Color.Gray

            });
            calendario.SpecialDates.Add(new XamForms.Controls.SpecialDate(DateTime.Now.AddDays(-7))
            {
                Selectable = false,
                TextColor=Color.OrangeRed,
                BackgroundColor = Color.Gray

            });
            
        }

        private async void irMensaje(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PantallaMensaje());
        }
    }
}