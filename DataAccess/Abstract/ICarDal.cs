using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // ekle sil gibi işlemleri yapacağım yer Dal 
    public interface ICarDal
    {
        List<Car> GetAll();
        void Add(Car product);
        void Update(Car product);
        void Delete(Car product);
        List<Car> GetById(Car BrandId);
    }
}
