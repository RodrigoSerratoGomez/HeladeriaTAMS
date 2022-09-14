using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using HeladeriaTAMS.Models;

namespace HeladeriaTAMS.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<HeladeriaTAMS.Models.Contacto> DataContactos { get; set; }
    public DbSet<HeladeriaTAMS.Models.Producto> DataProductos { get; set; }
}
