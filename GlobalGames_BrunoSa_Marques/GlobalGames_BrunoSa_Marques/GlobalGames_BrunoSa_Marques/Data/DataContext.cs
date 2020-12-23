using GlobalGames_BrunoSa_Marques.Data.Entities;
using GlobalGames_BrunoSa_Marques.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace GlobalGames_BrunoSa_Marques.Data
{
    public class DataContext : DbContext

    {

        public DbSet<Orcamento> Orcamentos { get; set; }


        public DbSet<Register> Registers { get; set; }


        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}

