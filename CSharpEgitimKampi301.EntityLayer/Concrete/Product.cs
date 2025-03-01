using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public int ProductStock { get; set; }
        public decimal ProductPrice { get; set; }

        public string ProductDescription { get; set; }

        public int CategoryId { get; set; } // Her bir ürünün mutlaka bir kategorisi olacak.

        public virtual Category Category { get; set; } // Category tablosunun değerlerine ürün üzerinden ulaşabilmek için

        public List<Order> Orders { get; set; }

        //[NotMapped]
        //public string CategoryName { get; set; }

    }
}


// Projede oluşturduğumuz tabloların ilişkilerini kuracağız. Bunun için her bir ürünün mutlaka bir kategorisi olmalı bu yüzden ürün tablosunda bir kategori ıd ile ilişkilendirme kuruyoruz. 

// Aynı zamanda bir ürünün kategori bilgisine ulaşmamız gerekiyor.

// Context : Code First yaklaşımında projenin veritabanı bağlantı adresini ve veritabanına yansıyacak olan tabloları tuttuğumuz bir sınıf görevini görmektedir.

// Virtual : Bir özelliğinin türetilmiş bir sınıfta yeniden tanımlanabileceği ve böylece farklı davranışlar sergileyebileceği anlamına gelir.
