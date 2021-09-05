using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

//namespace DataAccess.Concrete
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryCarDal()
//        {
//            _cars = new List<Car>
//            {
//                new Car{CarId=1,BrandId=1,ColorId=2,DailyPrice=150,ModelYear=2006,Description="Manual,2x Persons" },
//                new Car{CarId=2,BrandId=2,ColorId=3,DailyPrice=300,ModelYear=2020,Description="2x Luggage Quantity" },
//                new Car{CarId=3,BrandId=2,ColorId=2,DailyPrice=250,ModelYear=2019,Description="Manual,5x Persons" },
//                new Car{CarId=4,BrandId=1,ColorId=1,DailyPrice=200,ModelYear=2017,Description="Manual,5x Persons" }
                

//            };
//        }
//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            //LINQ
            
//            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);
//            _cars.Remove(carToDelete);
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetById(int Id)
//        {
//            return _cars.Where(c=>c.CarId == Id).ToList();
//        }

//        public List<Car> GetById(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<CarDetailDto> GetProductDetails()
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Car car) //Ekrandan gelen data car, güncel hali bu olacak.
//        {
//            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.Description = car.Description;
//            carToUpdate.ModelYear = car.ModelYear;
//            carToUpdate.CarName = car.CarName;
//        }

//        Car IEntityRepository<Car>.Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
