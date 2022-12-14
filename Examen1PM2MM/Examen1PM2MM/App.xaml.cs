using System;
using Examen1PM2MM.Controllers;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Examen1PM2MM
{
    public partial class App : Application
    {
        static UbicacionesDB basedatos;
        public static UbicacionesDB BaseDatos
        {
            get
            {
                if (basedatos == null)
                {
                    basedatos = new UbicacionesDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "UbicacionesDB.db3"));
                }

                return basedatos;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
