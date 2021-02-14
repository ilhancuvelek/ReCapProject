using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarContext>, ICarDal
    {
        

        List<CarDetailDto> ICarDal.GetCarDetail()
        {
            using (CarContext context = new CarContext())
            {
                var result = from c in context.Cars
                             join cl in context.Colors on c.ColorId equals cl.ColorId
                             join b in context.Brands on c.BrandId equals b.BrandId
                             select new CarDetailDto { ColorName = cl.ColorName, BrandName = b.BrandName, DailyPrice = c.DailyPrice, Id = c.Id };
                return result.ToList();
            }
        }
    }
}
