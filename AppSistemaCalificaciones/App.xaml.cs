using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppSistemaCalificaciones
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //habilitar navegacion entre ventanas
            MainPage = new NavigationPage( new Login());
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
