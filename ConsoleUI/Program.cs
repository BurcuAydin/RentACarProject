using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // BrandTest();
            GetCarDetails();
            //GetCarsByColorId();

        }

        private static void GetCarsByColorId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine(car.CarId);
            }
        }

        //CarName, BrandName, ColorName, DailyPrice
        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine(car.CarName +" " + car.BrandName +" "+ car.DailyPrice + " " + car.ColorName);
            } 
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            }
        }
    }
    }

