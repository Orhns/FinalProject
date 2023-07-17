using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    //SOLID
    //open closed principle
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var item in productManager.GetAll())
            //{
            //    Console.WriteLine(item.ProductName);
            //}

            //foreach (var item in productManager.GetAllByCategoryId(2))
            //{
            //    Console.WriteLine(item.ProductName);
            //}
            
            foreach (var item in productManager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(item.ProductName);
            }

        }
    }
}