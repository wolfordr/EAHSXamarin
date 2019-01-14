using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public double result = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button b = sender as Button;  // Typecast sender as a button

            if ("÷*+-".Contains(b.Text))
            {
                // This is an operator
            }

            lblDisplay.Text = "" + result;
        }
    }
}
