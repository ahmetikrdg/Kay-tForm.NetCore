using denemeewebui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace denemeewebui.Data
{
    public class ShopContext:DbContext
    {
    
        public DbSet<Person> products { get; set; }
        public static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddConsole(); });//entity komutum sqlde nasıl göremk için ekledim
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLoggerFactory(MyLoggerFactory).UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=ShopDbbbbbbb;Integrated Security=SSPI;");
        }
   
    }
}