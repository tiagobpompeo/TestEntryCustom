using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestEntry
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //string a = "RUA DAS URUGUAIAS ARGENTINAS E PARAGUAIS RSADSDFSFDFFSF asdfasdfafadadasdadadasdasdasdasdasdasdasdasd";
            //x.Text = a.ToLower();

            BindingContext = new VModel();

            //x.Text.ToLowerInvariant();
            // x.Text.ToLower(new CultureInfo("pt-BR", false));
        }
    }
}
