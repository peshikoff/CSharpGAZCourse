using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Task2();
            //Task3();
            //Task4a();
            //Task4b();
            Task5();
        }
       static void Task2()
        {
            //Объявляем переменную
            string line;
            //Присваиваем ей значение путем ввода из консоли
            line = Console.ReadLine();
            //Вывод в консоли
            Console.WriteLine(line);
        }
      static  void Task3()
       {
           string line;

           while ((line = Console.ReadLine()) != null)
           {
           Console.WriteLine(line);
           }
           
          }
       static void Task4a()
       {
           string line;
           while ((line = Console.ReadLine()) != null)
           {
           line = line.Replace(","," y:");
           Console.WriteLine(line);
           }
           
           
       }
    static void Task4b()
    {
        string line;
        while((line = Console.ReadLine()) != null)
        {
            line = line.Replace(","," y:");
            line = "x: " + line;
            Console.WriteLine(line);
        }
        
    }
    static void Task5()
    {
        try
        {
            using(var line1 = new StreamReader("E:/Labfiles/Lab 1/Ex1/Starter/ConsoleApplication/ConsoleApplication/DataFile.txt"))
            {
                Console.WriteLine("File: ");
                Console.WriteLine(line1.ReadToEnd());
                string line;
                line = new StreamReader("E:/Labfiles/Lab 1/Ex1/Starter/ConsoleApplication/ConsoleApplication/DataFile.txt").ReadToEnd();

                    line = line.Replace(",", " y:");
                    line = "x: " + line;
                    Console.WriteLine(line);
            }
        }
        catch(IOException e)
        {
            Console.WriteLine("File cant be read:");
            Console.WriteLine(e.Message);
        }
    }



    }
}
