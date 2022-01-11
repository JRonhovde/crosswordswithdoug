using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

namespace ef5crossword.Models
{
    public class Puzzle
    {
        public long Id { get; set; }
        public string Title { get; set; } = "";
        public DateTime Date { get; set; } 
        public bool Completed { get; set; } = false;
        public bool Checked { get; set; } = false;
        public ICollection<Square>? Squares { get; set;}
        public bool Active { get; set; }
    }
}
