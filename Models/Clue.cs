using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

namespace ef5crossword.Models
{
    public class Clue
    {
        public long Id { get; set; }
        public long PuzzleId { get; set; }
        public int Number { get; set; }
        public string Direction  { get; set; } = "";
        public string Text  { get; set; } = "";
    }
}
