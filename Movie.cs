namespace APIConsume
{
    public class MovieList
    {
        public int page { get; set; }
        public List<Movie> results { get; set; } = new();
    }

    public class Movie
    {
        public int id { get; set; }
        public string title { get; set; }
        public string overview { get; set; }
        public string poster_path { get; set; }

        public List<int> genre_ids { get; set; }

        public string Poster
        {
            get
            {
                return $"https://image.tmdb.org/t/p/w500/{poster_path}";
            }
        }
    }
}
