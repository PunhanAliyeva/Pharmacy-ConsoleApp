using System;

namespace Pharmacy_ConsoleApp
{
    class Program
    {
            Category category = new Category("Vitamins");
            Medicine medicine = new Medicine("VitaminA", 4, 16);
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
                        Console.WriteLine("choose one:");
                        string input2= Console.ReadLine();
                        switch (input2)
                        {
                            case "1":
                                category.Create();
                                break;
                            case "2":
                                category.Delete();
                                break;
                            case "3":
                                category.UpDate();
                                break;
                        }
                        break;
                    default:
                        break;
                    case "2":
                        Console.WriteLine("choose one:");
                        string input3= Console.ReadLine();
                        switch (input3)
                        {
                            case "1":
                                medicine.Create();
                                break;
                            case "2":
                                medicine.Delete();
                                break;
                            case "3":
                                medicine.UpDate();
                                break;
                            case "4":
                                medicine.SellMedicine();
                                break;

                            default:
                                break;
                        }
                        break;
                    }
              }
            while (input!="0");
  }
}
