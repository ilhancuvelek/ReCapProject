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
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
            new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2019,DailyPrice=200,Description="çok iyi"},
            new Car{Id=2,BrandId=2,ColorId=2,ModelYear=2018,DailyPrice=700,Description="kötü"},
            new Car{Id=3,BrandId=3,ColorId=3,ModelYear=2017,DailyPrice=300,Description="orta"},
            new Car{Id=4,BrandId=4,ColorId=4,ModelYear=2016,DailyPrice=100,Description="iyi"},

            };
        }
        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            var DeletedToCar = _cars.SingleOrDefault(p => p.Id == entity.Id);
            _cars.Remove(DeletedToCar);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            var UpdatedToCar = _cars.SingleOrDefault(p => p.Id == entity.Id);
            UpdatedToCar.Id = entity.Id;
            UpdatedToCar.ColorId = entity.ColorId;
            UpdatedToCar.BrandId = entity.BrandId;
            UpdatedToCar.DailyPrice = entity.DailyPrice;
            UpdatedToCar.ModelYear = entity.ModelYear;
            UpdatedToCar.Description = entity.Description;
            Console.WriteLine("kayıt eklendi");
        }
    }
}
