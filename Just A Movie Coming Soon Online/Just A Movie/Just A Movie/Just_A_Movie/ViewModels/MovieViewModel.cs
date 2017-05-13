using Just_A_Movie.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using Xamarin.Forms;

namespace Just_A_Movie.ViewModels
{
    class MovieViewModel : BindableObject
    {
        private ObservableCollection<Movie> movies = new ObservableCollection<Movie>();

        public ObservableCollection<Movie> Movies
        {
            get { return movies; }
            set
            {
                movies = value;
                OnPropertyChanged();
            }
        }

        public MovieViewModel()
        {
            loadMovieData();
        }

        public async Task loadMovieData()
        {
            var uri = new Uri(string.Format(Constants.RestUrl, string.Empty));
            HttpClient client = new HttpClient();

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    XDocument xmlFile = XDocument.Parse(content);
                    var query = from c in xmlFile.Descendants("item") select c;
                    foreach (XElement book in query)
                    {
                        Movie movie = new Movie();
                        movie.Title = book.Element("title").Value;
                        movie.Link2 = book.Element("link").Value;
                        movie.PubDate = book.Element("pubDate").Value;
                        movie.Category = book.Element("category").Value;
                        movie.Guid = book.Element("guid").Value;
                        movie.Description = RemoveHtmlTags(book.Element("description").Value);
                        
                        string image = (string)("<xml>" + IgnoreHtmlTags(book.Element("description").Value) + "</xml>");
                        XElement xe = XElement.Parse(image);
                        var query2 = from c in xe.Descendants("img") select c;
                        foreach (XElement book2 in query2)
                        {
                            movie.ImageUrl = book2.Attribute("src").Value;
                        }
                        movies.Add(movie);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
        
        string RemoveHtmlTags(string html)
        {
            return Regex.Replace(html, "<.+?>", string.Empty);
        }

        string IgnoreHtmlTags(string html)
        {
            MatchCollection mc = Regex.Matches(html, "<.+?>");
            string data = "";
            foreach (Match m in mc)
            {
                data += m.Value;
            }
            return data;
        }
    }
}
