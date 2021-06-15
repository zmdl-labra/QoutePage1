using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QoutesPage
{
    public partial class MainPage : ContentPage
    {
        private int _index = 0;
        private string[] _quotes = new string[]
        {
            "mbbjbjvjvjvjbnb",
            "xxxxxxxxxxxx",
            "cccccccccccccccc"
        };


        public MainPage()
        {
            InitializeComponent();

            currentQuote.Text = _quotes[_index];




        }

        private void NEXT_Clicked(object sender, EventArgs e)
        {

            _index++;
            if (_index >= _quotes.Length)
                _index = 0;
            currentQuote.Text = _quotes[_index];
        }
    }
}
