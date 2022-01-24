using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalProject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            App.Current.MainPage = new MyTabbed();
        }

        private  void ImageButton_Clicked(object sender, EventArgs e)
        {
            // await Navigation.PushAsync(new SecondPage());
        }

        private  void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new MagicPage());
        }
        private  void ImageButton_Clicked_2(object sender, EventArgs e)
        {
           // await Navigation.PushAsync(new MagicPage());
        }
    }
}