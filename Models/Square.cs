using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

namespace ef5crossword.Models
{
    public class Square
    {
        public long Id { get; set; }
        public long PuzzleId { get; set; }
        public string? Number { get; set; } = "";
        public string? Value { get; set; } = "";
        public string Color { get; set; } = "white";
        public bool Checked { get; set; } = false;
        public bool Correct { get; set; } = true;
    }
}
