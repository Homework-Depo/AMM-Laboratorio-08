using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Demo082023A
{
    public partial class DynamicDemo : ContentPage
    {
        bool originalStyle = true;



        public DynamicDemo()
        {
            InitializeComponent();
            Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (originalStyle)
            {
                Resources["searchBarStyle"] = Resources["greenSearchBarStyle"];
                originalStyle = false;
            }
            else
            {
                Resources["searchBarStyle"] = Resources["blueSearchBarStyle"];
                originalStyle = true;
            }
        }
    }

}

