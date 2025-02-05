using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryId { get; set; } 
        public string CategoryNmae { get; set; }

        public bool CategoryStatus { get; set; }
    }
}

// İlk olarak sınıf erişimini public olarak değiştirdik çünkü bu sınıfın diğer sınıflardan veya katmanlardan erişilmesi gerekecek.
// public int MyProperty { get; set; } --> prop + tab ile direk oluşturabiliriz.
// get: veriyi almak
// set: veriyi ayarlamak

// *** Code First yaklaşımı içeisinde Id sütununun birincil anahtar ve otomatik artan olduğunu bildirmek adına sınıfın ismi birebir aynı yazılmalı ve sonuna Id getirilmelidir.