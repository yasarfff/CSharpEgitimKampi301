using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class 
    // Şartımız: T değeri sadece class olacak, harici bir yerde çalışılmayacak.
    // Dal; DataAccess'ten gelir, Generic;Hepsini kapsayacak anlamına gelir.
    {

        void Insert(T entity); // Ekle
        void Update(T entity); // Güncelle
        void Delete(int id); // Id'ye göre silme
        List<T> GetAll(); // Tüm verileri getir.
        T GetById(int id);  



    }
}
