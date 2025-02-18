using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T entity); // Ekle
        void TUpdate(T entity); // Güncelle
        void TDelete(T entity); // Id'ye göre silme
        List<T> TGetAll(); // Tüm verileri getir.
        T TGetById(int id);
    }
}

// DataAccess katmanındaki metotlarımızla Business katmanındaki metotların birbiriyle karışmaması için buradaki metotların başına T harfi ekledik.