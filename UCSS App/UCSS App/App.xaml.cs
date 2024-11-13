using System;
using UCSS_App.Services;
using UCSS_App.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UCSS_App
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
