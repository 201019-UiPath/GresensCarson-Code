using System;
using Microsoft.EntityFrameworkCore;
using StoreLib.Models;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Collections.Generic;

namespace StoreDB
{
    public class StoreContext
    {
        
    /*public DbSet<Customer> Customers { get; set; }
    public DbSet<Employee> Employees { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!(optionsBuilder.IsConfigured))
      {
        var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

        var connectionString = @"Host=lallah.db.elephantsql.com;Port=5432;Database=efzgkaao;Username=efzgkaao;Password=wbQfq_L5qqsRTF3VIFhrcjsJfAg2KTuy;";
        optionsBuilder.UseNpgsql(connectionString);
      }
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<Order>()
      .HasOne(o => o.Price)
      .WithMany(o => o.Items)
      .HasForeignKey(o => o.Id);

    }
  
*/


    }
}