using WishlistExpress.Models;
using Microsoft.EntityFrameworkCore;

namespace WishlistExpress.Data;

public class ApplicationDbContext : DbContext
{
    //Contructor 
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    //Instance
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<Wishlist> Wishlists { get; set; }
    public DbSet<Submission> Submissions { get; set; }

}