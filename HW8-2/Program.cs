﻿using System;
using System.Linq;

namespace HW8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //ADO.NET
            //Entity Framework - ORM - Object Relation Mapping - nesnelerin veritabanıyla bağdaştırılması
            //NHibernate
            //Dapper

            //GetAll();
            GetProductsByCategory(5);
        } 

        private static void GetAll()
        {
            NorthwindContext northwindContext = new NorthwindContext();

            foreach (var product in northwindContext.Products)
            {
                Console.WriteLine(product.ProductName);
            }
        }


        private static void GetProductsByCategory(int categoryId)
        {
            NorthwindContext northwindContext = new NorthwindContext();

            var result = northwindContext.Products.Where(p => p.CategoryId == categoryId);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
