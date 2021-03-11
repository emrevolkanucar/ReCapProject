using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Marka
            //BrandManager brandManager = new BrandManager(new EfBrandDal());

            //// Yeni Marka Ekle 
            //Brand brand1 = new Brand { Name = "Mercedes" };
            //Brand brand2 = new Brand { Name = "Bmw" };
            //Brand brand3 = new Brand { Name = "Seat" };
            //brandManager.Add(brand1);
            //brandManager.Add(brand2);
            //brandManager.Add(brand3);

            //// Marka Guncelle
            //Brand brand4 = new Brand { Id = 1, Name = "Audi" };
            //brandManager.Update(brand4);

            //// Marka Sil
            //Brand deleteBrand = new Brand { Id = 3 };
            //brandManager.Delete(deleteBrand);

            //System.Console.WriteLine("------------ MARKA LISTESI ------------");
            //foreach (Brand brand in brandManager.GetAll())
            //{
            //    System.Console.WriteLine("Marka: " + brand.Name);
            //}

            //// Renk
            //ColorManager colorManager = new ColorManager(new EfColorDal());

            //// Yeni Renk Ekle
            //Color color1 = new Color { Name = "Turuncu" };
            //Color color2 = new Color { Name = "Gri" };
            //Color color3 = new Color { Name = "Siyah" };
            //Color color4 = new Color { Name = "Kirmizi" };
            //Color color5 = new Color { Name = "Mavi" };

            //colorManager.Add(color1);
            //colorManager.Add(color2);
            //colorManager.Add(color3);
            //colorManager.Add(color4);
            //colorManager.Add(color5);

            //// Renk Guncelle
            //Color colorUpdated = new Color { Id = 1, Name = "Siyah" };
            //colorManager.Update(colorUpdated);

            //// Renk Sil
            //Color colorDeleted = new Color { Id = 5 };
            //colorManager.Delete(colorDeleted);



            // Arac
            //CarManager carManager = new CarManager(new EfCarDal());

            // Yeni Araç Ekle
            // Car car1 = new Car { BrandId = 5, ColorId = 1, ModelYear = 2021, DailyPrice = 100, Description = "Fiat Egea" };
            //carManager.Add(car1);

            // Araç Güncelle
            //Car car2 = new Car { Id = 5, BrandId = 5, ColorId = 1, ModelYear = 2021, DailyPrice = 210, Description = "Seat Leon" };
            //carManager.Update(car2);

            // Araç Sil
            //Car car3 = new Car { Id = 5, BrandId = 5, ColorId = 1, ModelYear = 2021, DailyPrice = 210, Description = "Seat Leon" };
            //carManager.Delete(car3);

            //System.Console.WriteLine("------------ ARABA LISTESI ------------");

            //var result = carManager.GetAllWithDetails();

            //if(result.Success)
            //{
            //    foreach (CarDetailDto car in result.Data)
            //    {
            //        System.Console.WriteLine("Car Name: " + car.CarName + "\nBrand Name: " + car.BrandName + "\nColor Name: " + car.ColorName + "\nDaily Price: " + car.DailyPrice + "\n ------ ");
            //    }
            //    System.Console.WriteLine(result.Message);
            //} else
            //{
            //    System.Console.WriteLine(result.Message);
            //}

            /* Kullanıcı Ekle */
            UserManager userManager = new UserManager(new EfUserDal());
            //List<User> userList = new List<User>
            //{
            //    new User { FirstName = "Ali", LastName = "Uçar", Email = "aliucar@gmail.com", Password = "12345" },
            //    new User { FirstName = "Meltem", LastName = "Uçar", Email = "meltemucar@gmail.com", Password = "12345" },
            //    new User { FirstName = "Gizem", LastName = "Uçar", Email = "gizemucar@gmail.com", Password = "12345" }
            //};


            //foreach (User user in userList)
            //{
            //    userManager.Add(user);
            //    System.Console.WriteLine("Kullanıcı + " + user.FirstName + " " + user.LastName + " eklendi");
            //}

            /* Müşteri Ekle */
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            //// Müşteri bilgilerini alalım
            //List<Customer> customerList = new List<Customer>
            //{
            //    new Customer { UserId=1, CompanyName="Ups A.Ş." },
            //    new Customer { UserId=3, CompanyName="Mia Creative" }
            //};

            //foreach (Customer customer in customerList)
            //{
            //    customerManager.Add(customer);
            //}

            /* Araç Kirala */
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            List<Rental> rentalList = new List<Rental>
            {
                new Rental { CarId=6, CustomerId=1, RentDate=DateTime.Now, ReturnDate=DateTime.Now.AddDays(7)},
                new Rental { CarId=4, CustomerId=1, RentDate=DateTime.Now},
                new Rental { CarId=3, CustomerId=1, RentDate=DateTime.Now, ReturnDate=DateTime.Now.AddDays(2)},
                new Rental { CarId=4, CustomerId=2, RentDate=DateTime.Now, ReturnDate=DateTime.Now.AddDays(3)},
                 new Rental { CarId=2, CustomerId=2, RentDate=DateTime.Now, ReturnDate=DateTime.Now.AddDays(4)}
            };

            foreach (Rental rental in rentalList)
            {
                System.Console.WriteLine(rentalManager.Add(rental).Message);
            }


        }
    }
}
