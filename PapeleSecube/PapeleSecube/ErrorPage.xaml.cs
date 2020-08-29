using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PapeleSecube
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ErrorPage : ContentPage
    {
        public ErrorPage()
        {
            InitializeComponent();
        }
        private void Finished(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }
        private void Again(object sender, EventArgs e)
        {
            var profiles = Connectivity.NetworkAccess;
            if (profiles == NetworkAccess.Internet)
            {
                Navigation.PushModalAsync(new MainPage());
            }
        }
    }
}