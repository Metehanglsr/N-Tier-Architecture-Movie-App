﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.entity
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName{ get; set; }
        public string? Password{ get; set; }
        public string? Email { get; set; }
        public List<Movie>? FavoriteMovies{ get; set; }
        public List<Review>? Reviews{ get; set; }
    }
}
