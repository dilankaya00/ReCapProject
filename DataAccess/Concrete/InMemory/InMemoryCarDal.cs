using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{ Id=1,BrandId=1, ColorId=1, DailyPrice=250, Description="Ford araba",  ModelYear=2008},
            new Car{ Id=2, BrandId=2, ColorId=2, DailyPrice=150, Description="Renault araba" , ModelYear=2007},
            new Car{ Id=3, BrandId=2, ColorId=1, DailyPrice=200, Description="Renault araba" , ModelYear=2010},
            new Car{ Id=4, BrandId=3, ColorId=2, DailyPrice=450, Description="BMW araba" , ModelYear=2012},
            new Car{ Id=5, BrandId=2, ColorId=1, DailyPrice=500, Description="Mercedes araba" , ModelYear=2018}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;






        }
    }
}
