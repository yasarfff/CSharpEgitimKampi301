using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Context
{
    public class KampContext: DbContext // Veritabanına yansıyacak olan tüm sınıflarımız bunun içinde bulunacak.
    {
        public DbSet<Category> Categories  { get; set; } // Category; sınıf ismi, Categories; sql'e yansıyacak olan tablo ismi
        public DbSet<Product> Products { get; set; } 
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}

// DbSet: Bunun bir tablo olduğunu uygulamaya bildirdiğimiz kısım.