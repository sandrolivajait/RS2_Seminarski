using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Mobitel.CustomerFacing.Services;
using Mobitel.CustomerFacing.Views;

namespace Mobitel.CustomerFacing
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
