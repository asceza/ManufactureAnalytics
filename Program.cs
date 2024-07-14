using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;


namespace ManufactureAnalytics
{
    class Program
    {
        static void Main()
        {
            // Создание списка сотрудников
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Иван Иванов"));
            employees.Add(new Employee("Петр Петров"));

            // Создание списка изделий
            List<Product> products = new List<Product>();
            products.Add(new Product("Панель А", "2.050/24", 25));
            products.Add(new Product("Панель B", "2.050/24", 25));



            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Записать данные изготовления изделия Панель А");
                Console.WriteLine("2. Показать историю изготовления изделия Панель А");
                Console.WriteLine("3. Показать время присутствия работника Иван Иванов на рабочем месте");
                Console.WriteLine("4. Выйти");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Запись данных изготовления изделия
                        Console.WriteLine("Введите время в часах, затраченное на работу с изделием Панель А");
                        float leadTimeInHours = Convert.ToSingle(Console.ReadLine());

                        //Console.WriteLine("Введите название изделия:");
                        //string productTitle = "Панель А";

                        //Console.WriteLine("Введите ФИО сотрудника:");
                        //string employeeFullName = "Иван Иванов";

                        // Выполняет поиск элемента, удовлетворяющего условиям указанного предиката,
                        // возвращает первое найденное вхождение в пределах всего списка
                        Product currentProduct = products.Find(x => x.Title.Contains("Панель А"));

                        // Запись данных во внешний файл в формате CSV
                        using (StreamWriter writer = File.AppendText("data.csv"))
                        {
                            writer.WriteLine($"{currentProduct.Title};" +
                                             $"{currentProduct.NumberProduct};" +
                                             $"{currentProduct.NumberTrain};" +
                                             $"{leadTimeInHours};" +
                                             $"{currentProduct.Status}");
                        }

                        Console.WriteLine("Данные успешно записаны!");
                        break;


                    default:
                        Console.WriteLine("Некорректный выбор!");
                        break;
                }
            }



        }
    }
}