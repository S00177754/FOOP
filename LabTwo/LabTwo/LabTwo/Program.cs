using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            QuestionFive();

            Console.ReadKey();
        }

        //Question One
        static void QuestionOne()
        {
            Console.Write("Please Enter Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(AgeCheck(age)); 
        }

        static bool AgeCheck(int userAge)
        {
            bool access = false;

            if(userAge >= 18 && userAge <= 21)
            {
                access = true;
            }

            return access;
        }

        //Question Two
        static void QuestionTwo()
        {
            Console.Write("Please Enter Product Name: ");
            string productName = Console.ReadLine();
            Console.WriteLine(PriceCheck(productName));
        }

        static double PriceCheck(string product)
        {
            double productPrice = 0.0;
            product = product.ToUpper();

            switch (product)
            {
                case "JEANS":
                    productPrice = 67.99;
                    break;

                case "JACKET":
                    productPrice = 68.99;
                    break;

                case "BOOTS":
                    productPrice = 34.99;
                    break;

                case "SCARVES":
                case "BELTS":
                case "SOCKS":
                    productPrice = 10.0;
                    break;

                default:
                    productPrice = -999;
                    break;
            }

            return productPrice;
        }

        //QuestionThree
        static void QuestionThree()
        {
            int[] example = { 24, 50, 49, 21, 88, 100 };
            foreach (var item in example)
            {
                Console.Write(item + ",");
            }

            Zero(example);

            foreach (var item in example)
            {
                Console.Write(item + ",");
            }

        }

        static void Zero(int[] argArray)
        {
            for (int i = 0; i < argArray.Length; i++)
            {
                argArray[i] = 0;
            }
            Console.WriteLine("Converted");
        }

        //Question Four
        static void QuestionFour()
        {
            Console.Write("Please enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Total: " + Sum(num1,num2));
        }

        static int Sum(int n1, int n2)
        {
            int total = 0;

            while(n1 <= n2)
            {
                if (n1 % 2 == 0)
                {
                    total += n1;
                }

                n1++;
            }

            return total;
        }

        //Question Five
        static void QuestionFive()
        {
            int storeStock = 25;

            Console.WriteLine("Store Stock:"  + storeStock);

            Console.Write("Sales Amount: ");
            int sales = int.Parse(Console.ReadLine());
            StockCheck(ref storeStock, sales);
            Console.WriteLine("Store Stock:" + storeStock);
        }

        static bool StockCheck(ref int stock, int sales)
        {
            bool stockUpdated = false;

            if(sales <= stock)
            {
                stock -= sales;
                stockUpdated = true;
            }

            return stockUpdated;
        }

        //Question Six
        static void QuestionSix()
        {

        }
    }
}
