
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
}
}