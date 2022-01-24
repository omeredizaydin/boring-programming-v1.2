using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
           
        }
       



        private void Button_Clicked(object sender, EventArgs e)
        {

           

        }
    }

   
    public class Test
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public string Job { get; set; }
        public string House { get; set; }
        public string Wand { get; set; }

        public string Patronus { get; set; }
        public string Species { get; set; }
        public string Blood_status { get; set; }

        public string Hair_colour { get; set; }
        public string Eye_colour { get; set; }
        public string Loyalty { get; set; }
        public string Skills { get; set; }
        public string Birth { get; set; }
        public string Death { get; set; }      


    }
}