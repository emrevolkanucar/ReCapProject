using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetAllWithDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from cr in context.Cars
                             join br in context.Brands on cr.Id equals br.Id
                             join co in context.Colors on cr.ColorId equals co.Id

                             select new CarDetailDto
                             {
                                 CarId = cr.Id,
                                 CarName = cr.Description,
                                 BrandName = br.Name,
                                 ColorName = co.Name,
                                 DailyPrice = cr.DailyPrice
                             };

                return result.ToList();
            }
        }
    }
}
