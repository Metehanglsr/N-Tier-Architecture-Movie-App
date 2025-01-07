using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movieapp.entity
{
    public class Review
    {
        public int Id { get; set; }
        public string? Comment { get; set; }
        public Int16 LikeCount { get; set; } = 0;
        public DateOnly CreatedAt { get; set; }
        public int MovieId { get; set; }
        public Movie? Movie { get; set; }
        public int UserId { get; set; }
        public required User User{ get; set; }

    }
}
