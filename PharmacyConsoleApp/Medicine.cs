using CategoryConsoleApp.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CategoryConsoleApp
{
    class Medicine
    {
        private int _medicineId;
        private string input;

        public int MedicineId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public Medicine(string name,double price,int count)
        {
            _medicineId++;
            MedicineId = _medicineId;
            Name = name;
            Price = price;
            Count = count;
        }

        public Medicine(string input)
        {
            this.input = input;
        }

        public void Create()
        {
            Console.WriteLine("Enter the medicine's name:");
            string input = Console.ReadLine();
            Medicine medicine = new Medicine(input);
            Context.Medicines.Add(medicine);
        }
        public void Delete()
        {
            Console.WriteLine("Enter the category's name:");
            string input = Console.ReadLine();
            Medicine medicine = new Medicine(input);
            Context.Medicines.Remove(medicine);
        }
        public void UpDate()
        {

        }
    }
}
