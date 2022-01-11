using ef5crossword.Models;
using System;
using System.Linq;

namespace ef5crossword.Data
{
    public static class DbInitializer
    {
        public static void Initialize(PuzzleContext context)
        {
            context.Database.EnsureCreated();

            //Look for any Squares
            if(context.Squares.Any())
            {
                return; //db has been seeded
            }
            var puzzle = new Puzzle{Id=1,Active=true};
            context.Puzzles.Add(puzzle);

            var squares = new Square[]
            {
                new Square{Color="white", Number=""}
            };
        }

    }


    
}