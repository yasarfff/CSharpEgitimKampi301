using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfAdminDal: GenericRepository<Admin>, IAdminDal
         // IAdminDal'dan miras almasının sebebi sadece admin sınıfına özgün metot yazabilmemiz için.
    {
    }
}
 /*
  Entitye özgü olmayan metotlar : Ekle, Sil, Güncelle, Listele ve Id'ye Göre Getir. Bunlar sistemdeki tüm metotlar için geçerli olan metotlardır.
  */