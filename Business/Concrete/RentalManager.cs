using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {

            if (!CheckRentalCar(rental.CarId))
            {
                return new ErrorResult("Araç henüz kiradan dönmemiş. Kiralanmaya uygun değil.");
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }

        public bool CheckRentalCar(int carId)
        {
            // Null veya return date ileri bir tarih ise teslim edilmemiştir == false

            Rental checkRental = (_rentalDal.GetAll(x => x.CarId == carId && (x.ReturnDate == null || x.ReturnDate > DateTime.Now))).FirstOrDefault();
            if (checkRental != null)
            {
                return false;
            }
            return true;
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.RentalListed);
        }

        public IDataResult<List<Rental>> GetById(int Id)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(x => x.Id == Id), Messages.RentalListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalEdited);
        }
    }
}
