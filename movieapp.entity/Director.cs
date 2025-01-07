using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.entity
{
    public class Director
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<MovieDirector> Directors { get; set; } = new List<MovieDirector>();
    }
}
