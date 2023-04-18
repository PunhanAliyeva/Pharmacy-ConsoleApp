using CategoryConsoleApp.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace CategoryConsoleApp
{
    class Category
    {
        private int _categoryId;
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public Category(string name)
        {
            _categoryId++;
            CategoryId = _categoryId;
            Name = name;
        }
        public void Create()
        {
            Console.WriteLine("Enter the category's name:");
            string input = Console.ReadLine();
            Category category = new Category(input);
            Context.Categories.Add(category);
        }
        public void Delete()
        {
            Console.WriteLine("Enter the category's name:");
            string input = Console.ReadLine();
            Category category = new Category(input);
            Context.Categories.Remove(category);
        }
        public void UpDate()
        {
            Console.WriteLine("Enter the category's name:");

        }

    }
}

