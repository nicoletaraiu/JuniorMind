/*Cumpărături
Ai un coș plin de produse. Dacă cunoști prețul fiecărui produs în parte:
Calculează care e totalul de plată pentru coșul cu cumpărături
Găsește și care e cel mai ieftin produs din coș
Elimină cel mai scump produs din coș
Adaugă un nou produs în coș
Calculează prețul mediu*/

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart
{
    [TestClass]
    public class ShoppingCart
    {
        [TestMethod]
        public void TotalPriceTest()
        {
            var products = new Product[] { new Product("Soda", (decimal)6.5), new Product("Salt", (decimal)2.25), new Product ("Chips", (decimal)3.45), new Product("Apples", (decimal)4.99)};
            Assert.AreEqual((decimal)17.19, CalculateTotalPrice(products));
        }

        [TestMethod]
        public void GetCheapestProductTest()
        {
            var products = new Product[] { new Product("Soda", (decimal)6.5), new Product("Salt", (decimal)2.25), new Product("Chips", (decimal)3.45), new Product("Apples", (decimal)4.99) };
            Assert.AreEqual(products[1] , GetCheapestProduct(products));
        }

        [TestMethod]
        public void MeanPriceTest()
        {
            var products = new Product[] { new Product("Soda", (decimal)6.5), new Product("Salt", (decimal)2.25), new Product("Chips", (decimal)3.45), new Product("Apples", (decimal)4.99) };
            Assert.AreEqual((decimal)4.2975, GetMeanPrice(products));
        }

        [TestMethod]
        public void DeleteMostExpensiveProductTest()
        {
            var products = new Product[] { new Product("Soda", (decimal)6.5), new Product("Salt", (decimal)2.25), new Product("Chips", (decimal)3.45), new Product("Apples", (decimal)4.99) };
            DeleteMostExpensive(products);
            bool test = products[0].product != "Soda";
            Assert.IsTrue(test);
        }

        [TestMethod]
        public void AddNewProductTest()
        {
            var products = new Product[] { new Product("Soda", (decimal)6.5), new Product("Salt", (decimal)2.25), new Product("Chips", (decimal)3.45), new Product("Apples", (decimal)4.99) };
            AddNewProduct(ref products);
            bool test = products[products.Length - 1].product == "Milk";
            Assert.IsTrue(test);
        }


        public struct Product
           {
            public string product;
            public decimal price;

            public Product(string product, decimal price)
                {
                   this.product = product;
                   this.price = price;
                }
            }

        static decimal CalculateTotalPrice(Product[] products)
        {
            decimal totalPrice = 0;
            for(int i = 0; i < products.Length; i++)
            {
                totalPrice += products[i].price;
            }
            return totalPrice;
        }


        static Product GetCheapestProduct(Product[] products)
        {
            Product smallestPriceProduct = products[0];
            for (int i = 1; i < products.Length; i++)
            {
                if (products[i].price < smallestPriceProduct.price)
                    smallestPriceProduct = products[i];
            }
            
                    return smallestPriceProduct;
            

        }

        static decimal GetMeanPrice(Product[] products)
        {
            return CalculateTotalPrice(products) / products.Length;
        }


        static void DeleteMostExpensive(Product[] products)
        {
            int mostExpensive = FindPositionOfMostExpensive(products);

            products[mostExpensive] = products[products.Length - 1];
            
            Array.Resize(ref products, products.Length - 1);
        }

        private static int FindPositionOfMostExpensive(Product[] products)
        {
            int mostExpensive = 0;
            for (int i = 1; i < products.Length; i++)
            {
                if (products[i].price > products[mostExpensive].price)
                    mostExpensive = i;
            }

            return mostExpensive;
        }

        static void AddNewProduct( ref Product[] products)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = new Product("Milk", (decimal)3.99);

        }



        
            
     }

 }

