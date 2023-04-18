using System;

namespace CategoryConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Category category = new Category("Vitamins");
            Medicine medicine = new Medicine("VitaminA",4,16);

            string input = " ";
            do
            {
                Console.WriteLine("Welcome to Pharmacy");
                Console.WriteLine("Menu:");
                Console.WriteLine("1.Category menu:");
                Console.WriteLine("2.Medicine menu:");
                Console.WriteLine("0.Exit");
                Console.Write("Please choose one: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        category.Create();
                        break;
                    case "2":
                        category.Delete();
                        break;
                    case "3":
                        //category.Update();
                        break;
                    default:
                        break;
                }
        }
               while (input!="0");
               switch (input)
            {
                case "1":
                    medicine.Create();
                    break;
                case "2":
                    medicine.Delete();
                    break;
                case "3":
                    //medicine.Update();
                    break;
                default:
                    break;
            }
               while (input != "0") ;
         }
    }
}
