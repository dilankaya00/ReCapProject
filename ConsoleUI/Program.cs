using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var car in carManager.GetCarsByBrandId(2))
            {
                //Console.WriteLine("Id of the car "+car.Id);
                //Console.WriteLine("Daily Price of the car "+car.DailyPrice);
                //Console.WriteLine("Model Year of the car "+car.ModelYear);
                //Console.WriteLine("Description of the car "+car.Description);
                Console.WriteLine(car.BrandId);
            }
        
        
        }
    }
}
