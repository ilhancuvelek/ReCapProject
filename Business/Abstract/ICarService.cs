using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
        IDataResult<List<Car>> GetAllByBrandId(int Bıd);
        IDataResult<List<Car>> GetAllByColorId(int Cıd);
        IDataResult<List<CarDetailDto>> GetCarDetail();
        IResult AddTransactionTest(Car car);
    }
}
