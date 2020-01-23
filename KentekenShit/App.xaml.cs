using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using KentekenShit.Services;
using KentekenShit.Views;

namespace KentekenShit
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            // DependencyService.Register<MockDataStore>();
            DependencyService.Register<SQLiteDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
