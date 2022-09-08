using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMeemory;
using System;

namespace ConsoleUI
{
    public class Class1
    {
        static void Main(string[] args) 
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.ColorId+" "+c.Description);
            }
        }
    }
}
