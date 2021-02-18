using System;
using System.IO;

namespace FileIOPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Путь по умолчанию: D:\\c#Homework\\information.txt");

            Console.Write("Введите полный путь: ");
            string writePath = Console.ReadLine();

            if (string.IsNullOrEmpty(writePath))
            {
                writePath = @"D:\c#Homework\information.txt";
            }

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите вашу фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите ваш возраст: ");

            

            int age = int.Parse(Console.ReadLine());
            try
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(name);
                    sw.WriteLine(surname);
                    sw.WriteLine(age);
                }
                Console.WriteLine("Запись выполнена");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
