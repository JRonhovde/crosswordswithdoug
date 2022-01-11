using ef5crossword.Models;
using Microsoft.EntityFrameworkCore;

namespace ef5crossword.Data
{
    public class PuzzleContext : DbContext
    {
        public PuzzleContext(DbContextOptions<PuzzleContext> options) : base(options)
        {
        }

        public DbSet<Square> Squares { get; set; }
        public DbSet<Puzzle> Puzzles { get; set; }
        public DbSet<Clue> Clues { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Square>().ToTable("Square");
            modelBuilder.Entity<Puzzle>().ToTable("Puzzle");
            modelBuilder.Entity<Clue>().ToTable("Clue");
        }
    }
}
