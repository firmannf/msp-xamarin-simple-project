using Just_a_Movie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Just_a_Movie.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(Movie movie)
        {
            InitializeComponent();
            imagePoster.Source = movie.ImageUrl;
            labelTitle.Text = movie.Title;
            labelCategory.Text = movie.Category;
            labelDescription.Text = movie.Description;
        }
    }
}
