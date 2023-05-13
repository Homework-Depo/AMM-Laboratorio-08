using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo082023A
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new Page1();
            // MainPage = new Page2();
            // MainPage = new DynamicDemo();
            MainPage = new CSSDemo();
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
