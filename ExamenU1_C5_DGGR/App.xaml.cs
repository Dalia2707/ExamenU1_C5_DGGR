using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ExamenU1_C5_DGGR.Vista;

namespace ExamenU1_C5_DGGR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Page1();
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
