﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Servicios.Services;
using Servicios.Views;

namespace Servicios
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new NavigationPage(new Inicio());
            MainPage = new Inicio();
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
