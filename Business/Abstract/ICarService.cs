﻿using Core.Utilities.Results;
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
        IDataResult<Car> GetByCarId(int carId);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetCarsByDailyPrice(decimal min, decimal max);
       
        IDataResult<List<CarDetailDto>> GetByModelYear(int modelYear);

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
    
}
