using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using g2a.Views;

namespace g2a
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

             MainPage = new NavigationPage(new HomeTabbedPage()) { BarBackgroundColor = Color.Black };
            
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
