﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{

    //SOLID
    //Open Closed Principle
    class Program
    {

        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
            //ProductManager productManager = new ProductManager(new EfProductDal());
            



        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName + " / "  + item.CategoryName );
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
        }
    }
}
