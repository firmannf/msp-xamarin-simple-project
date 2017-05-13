using Just_a_Movie.Models;
using Just_a_Movie.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Just_a_Movie.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MovieViewModel();
        }

        private void OnMoviesItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedMovie = e.SelectedItem as Movie;
            if (selectedMovie != null)
            {
                Navigation.PushAsync(new DetailPage(selectedMovie));
                var listview = sender as ListView;
                if (listview != null)
                    listview.SelectedItem = null;
            }
        }
    }
}
