using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car> {
                new Car {Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2016, DailyPrice = 100, Description = "BMW 1.18i" },
                new Car {Id = 2, BrandId = 2, ColorId = 1, ModelYear = 2018, DailyPrice = 80, Description = "FORD FOCUS" },
                new Car {Id = 3, BrandId = 3, ColorId = 3, ModelYear = 2014, DailyPrice = 110, Description = "AUDİ A6" },
                new Car {Id = 4, BrandId = 3, ColorId = 2, ModelYear = 2017, DailyPrice = 70, Description = "TOYOTA COROLLA" },
                new Car {Id = 5, BrandId = 4, ColorId = 3, ModelYear = 2013, DailyPrice = 120, Description = "MERCEDES E220" },
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
            _car.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
        }
    }
}
