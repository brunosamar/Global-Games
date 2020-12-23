using GlobalGames_BrunoSa_Marques.Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace GlobalGames_BrunoSa_Marques.Data
{
    public class DataContext : DbContext

    {

        public DbSet<Orcamento> Orcamentos { get; set; }




        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}

