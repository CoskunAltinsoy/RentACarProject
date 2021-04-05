using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //ColorTest();
            UserManager userManager = new UserManager(new EfUserDal());

            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(new Rental { Id=4, CarId = 3, CustomerId = 1, RentDate = new DateTime(2021, 04, 01), ReturnDate = new DateTime(2021, 04, 04) });
            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarTest()
        {
            CarManager carManeger = new CarManager(new EfCarDal());
            var result = carManeger.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + " / " + car.BrandName + " / " + car.ColorName + "/" + car.DailyPrice);
                }
            }

            else
            {
                Console.WriteLine(result.Message);
            }
            
            Console.WriteLine("**********");

            //carManeger.Add(new Car { Id = 6, BrandId = 2, ColorId = 4, ModelYear = 2018, DailyPrice = 140, Description = "Audi Q7" });
            //foreach (var car in carManeger.GetAll())

            //{
            //    Console.WriteLine("Brand : " + car.Description + " Color: " + car.DailyPrice + " Daily Price: " + car.ModelYear);
            //}
            //Console.WriteLine("**********");


            //carManeger.Update(new Car { Id = 6, BrandId = 2, ColorId = 4, ModelYear = 2018, DailyPrice = 165, Description = "Audi Q7" });
            //foreach (var car in carManeger.GetAll())

            //{
            //    Console.WriteLine("Brand : " + car.Description + " Color: " + car.DailyPrice + " Daily Price: " + car.ModelYear);
            //}
            //Console.WriteLine("**********");


            //carManeger.Delete(new Car { Id = 6 });
            //foreach (var car in carManeger.GetAll())

            //{
            //    Console.WriteLine("Brand : " + car.Description + " Color: " + car.DailyPrice + " Daily Price: " + car.ModelYear);
            //}
        }
    }
}
