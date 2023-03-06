using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TorrichelliGlasses.Domain;
using TorrichelliGlasses.Models.Product;
using TorrichelliGlasses.Models.Client;

namespace TorrichelliGlasses.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<TorrichelliGlasses.Models.Product.ProductCreateVM> ProductCreateVM { get; set; }
        public DbSet<TorrichelliGlasses.Models.Product.ProductIndexVM> ProductIndexVM { get; set; }
        public DbSet<TorrichelliGlasses.Models.Product.ProductEditVM> ProductEditVM { get; set; }
        public DbSet<TorrichelliGlasses.Models.Product.ProductDetailsVM> ProductDetailsVM { get; set; }
        public DbSet<TorrichelliGlasses.Models.Product.ProductDeleteVM> ProductDeleteVM { get; set; }
        public DbSet<TorrichelliGlasses.Models.Client.ClientDeleteVM> ClientDeleteVM { get; set; }
    }
}
