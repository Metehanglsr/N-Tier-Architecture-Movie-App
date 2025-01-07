using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.entity
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Plot { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public string? Duration { get; set; }
        public string? Rating{ get; set; }
        public string? ImageUrl{ get; set; }
        public string? TrailerUrl{ get; set; }
        public bool IsScreening { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
        public List<MovieActor> MovieActors { get; set; } = new List<MovieActor>();
        public List<MovieDirector> MovieDirectors { get; set; } = new List<MovieDirector>();


    }
}
