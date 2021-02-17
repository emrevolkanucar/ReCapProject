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
            _cars = new List<Car>
            {
                new Car {Id = 1, BrandId = 2, ColorId = 3, ModelYear = 2012, DailyPrice = 250, Description = "Golf 6"},
                new Car {Id = 1, BrandId = 3, ColorId = 1, ModelYear = 2018, DailyPrice = 250, Description = "Polo"},
                new Car {Id = 1, BrandId = 6, ColorId = 2, ModelYear = 2019, DailyPrice = 250, Description = "Passat"},
                new Car {Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2021, DailyPrice = 450, Description = "Mercedes A180"},
                new Car {Id = 1, BrandId = 1, ColorId = 5, ModelYear = 2021, DailyPrice = 450, Description = "Mercedes C180"}
            };
        }

        // Add
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        // Delete
        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        // GetAll
        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        // Update
        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
