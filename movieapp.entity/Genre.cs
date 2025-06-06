﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.entity
{
    public class Genre
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
    }
}
