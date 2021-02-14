using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUIII
{
    class Program
    {
        static void Main(string[] args)
        {
            RentalTest();
            //CarTest();
            //ColorTest();
            //BrandTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand {BrandId=7,BrandName="şahin" });
            var result = brandManager.GetAll();
            if (result.Success)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandId + " " + brand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color {ColorId=7,ColorName="turuncu" });
            var result = colorManager.GetAll();
            if (result.Success)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorId + " " + color.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            //carManager.Add(new Car { Id = 7, BrandId = 7, ColorId = 7, DailyPrice = 300, ModelYear = 1998, Description = "güzel" });
            var result = carManager.GetCarDetail();
            if (result.Success)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.Id + " / " + car.BrandName + " / " + car.ColorName + " / " + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetail();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.CarId + " " + item.CarName + " ");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
