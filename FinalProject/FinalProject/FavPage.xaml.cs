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
    public partial class FavPage : ContentPage
    {
        public FavPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var tab = this.Parent as TabbedPage;
            tab.CurrentPage = tab.Children[0];
           


        }
    }
}