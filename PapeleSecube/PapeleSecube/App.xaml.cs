using System;
using System.Linq;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PapeleSecube
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var profiles = Connectivity.NetworkAccess;
            if (profiles == NetworkAccess.Internet)
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new ErrorPage();
            }
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
