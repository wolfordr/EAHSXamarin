using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloJ315
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            count++;
            MyLabel.Text = "Button Pressed " + count + " Times!";
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            count++;
            MyLabel.Text = "Cookie Pressed " + count + " Times!";
        }
    }
}
