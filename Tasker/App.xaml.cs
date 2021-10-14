
using System;
using Tasker.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tasker
{
    public partial class App : Application
    {
        public App()
        { 
            InitializeComponent();

            MainPage = new MainShellPage();
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
