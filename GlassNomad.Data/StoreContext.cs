
using Glassnomad.Domain.Orders;
using GlassNomad_Api.Api.Domain.Catalog;
using Microsoft.EntityFrameworkCore; 

namespace GlassNomad.Data 
{ 
    public class StoreContext: DbContext 
    { 
        public StoreContext( DbContextOptions< StoreContext> options)
           : base( options) 
{}
public DbSet<Item> Items { get; set; }

public DbSet<Order> Orders {get ; set;}
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            DbInitializer.Initialize(builder);

        }
    }
}