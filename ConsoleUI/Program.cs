using Business.Abstract;
using Business.Concrete;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using Data_Access.Concrete.EntityFramework;
using Data_Access.Concrete.NHibernate;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // IoC Container :> Ninject, Autofac, Structure Map

            IProductService productService = new ProductManager(new EfProductDal());
            //IProductService productService2 = new ProductManager(new NhProductDal());
            foreach (var product in productService.GetAll())
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadLine();
        }
    }
}
