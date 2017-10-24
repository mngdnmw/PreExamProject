using JokeAppDAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace JokeAppDAL.Context
{
    class EASVContext : DbContext
    {
        public EASVContext(DbContextOptions<EASVContext> options): base(options)  { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Joke> Jokes { get; set; }
       
    }
}