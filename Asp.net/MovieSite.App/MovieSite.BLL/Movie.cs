using System;

namespace MovieSite.BLL
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public DateTime DateReleased { get; set; }
    }
}
