
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class RestaurantDbRepository : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database = RestaurantDb;Trusted_Connection = true");
        }


        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Star> Stars { get; set; }
        public DbSet<RestaurantOpinion> RestaurantOpinions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }


    }

}