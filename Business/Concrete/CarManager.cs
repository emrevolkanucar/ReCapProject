using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            this._carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<CarDetailDto> GetAllWithDetails()
        {
            return _carDal.GetAllWithDetails();
        }

        public List<Car> GetById(int Id)
        {
            return _carDal.GetAll(x=> x.Id == Id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
