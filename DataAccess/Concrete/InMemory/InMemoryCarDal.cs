using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMeemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
            new Car {Id=1, ColorId=1, BrandId=1, ModelYear=2000, DailyPrice=100, Description="Ticari"},
            new Car {Id=2, ColorId=2, BrandId=2, ModelYear=2001, DailyPrice=90,Description="sedan" },
            new Car {Id=3, ColorId=3, BrandId=3, ModelYear=2002, DailyPrice=110, Description="sedan"}
        };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _cars.ToList();

        }

        public List<Car> GetById(Car brandId)
        {
            return _cars.Where( c => c.BrandId == brandId.BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            foreach (Car carToUpdate in _cars)
            {
                carToUpdate.Id=car.Id;
                carToUpdate.ModelYear=car.ModelYear;
                carToUpdate.DailyPrice=car.DailyPrice;
                carToUpdate.Description=car.Description;
                carUpdate.ColorId=car.ColorId;
                carToUpdate.BrandId=car.BrandId;
            }            
        }
    }
}
