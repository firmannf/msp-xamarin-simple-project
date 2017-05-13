using Just_a_Movie.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Just_a_Movie
{
    class MovieViewModel : BindableObject
    {
        private List<Movie> movies;

        public List<Movie> Movies
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
            movies = new List<Movie>
            {
                new Movie{
                    Title="ALIEN:COVENANT",
                    PubDate="Wed, 26 Apr 2017",
                    Category="Sci-Fi",
                    Description="Ridley Scott kembali ke dunia yang dia ciptakan dengan kembali menyutradarai film dari franchise ALIEN terbaru, yakni ALIEN: COVENANT. Sekitar 10 tahun pasca Prometheus, pesawat luar angkasa Covenant membawa koloni manusia yang berniat untuk tinggal di sebuah planet baru di ujung galaksi. Mereka menyangka telah menemukan surga yang belum pernah dijelajahi sebelumnya, namun ternyata planet tersebut adalah sebuah tempat yang berbahaya. Ketika mereka menghadapi ancaman yang tidak terbayangkan sebelumnya, mereka harus berusaha untuk menyelamatkan diri..",
                    ImageUrl="Alien.jpg"
                },
                new Movie{
                    Title="BEFORE I FALL",
                    PubDate="Wed, 26 Apr 2017",
                    Category="Drama",
                    Description="Samantha (Zoey Deutch) memiliki kehidupan yang sempurna. Semua yang ia inginkan seakan-akan selalu bisa ia dapatkan. Hingga suatu ketika, semua kebahagiaan tersebut sirna dalam satu hari. Samantha terlibat dalam sebuah kecelakaan mobil tragis yang merenggut seluruh kebahagiaan dan hidup Samantha. Namun anehnya ia terus terjebak dalam misteri hari kematiannya secara berulang-ulang..",
                    ImageUrl="Before.jpg"
                },
                new Movie{
                    Title="SELEBGRAM",
                    PubDate="Wed, 26 Apr 2017",
                    Category="Comedy",
                    Description="Hidup Kamal bagaikan diujung tanduk ketika bapaknya berutang banyak pada rentenir. Meskipun begitu, Kamal selalu mencari jalan untuk membantu Bapaknya. Dia berharap bisa menjadi Selebgram agar bisa mendapat endorse dan menghasilkan uang. Sayang, menjadi Selebgram bukanlah perkara mudah.",
                    ImageUrl ="Selebgram.jpg"
                },
                new Movie{
                    Title="THE SPACE BETWEEN US",
                    PubDate="Wed, 26 Apr 2017",
                    Category="Adventure",           
                    Description="Sekelompok astronot diutus untuk pergi ke dalam misi penelitian di Mars. Ketika mendarat, salah seorang astronot menemukan jika ia tengah mengandung. Tidak lama kemudian astronot itu meninggal setelah ia melahirkan seorang bayi lelaki. ",
                    ImageUrl ="Space.jpg"
                },
                new Movie{
                    Title="UNLOCKED",
                    Category="Action",
                    PubDate="Wed, 27 Apr 2017",
                    Description="Alice Racine (Noomi Rapace) adalah seorang mantan agen lapangan CIA yang kini hidup tenang di London, Inggris. Alice kini harus bertugas menjadi petugas sosial karena sebuah kegagalan tugas di masa lalu.",
                    ImageUrl ="Unlocked.jpg"
                }
            };
        }
    }
}
