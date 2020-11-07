using System;
using System.Collections.Generic;

namespace lab01_my_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуй, странник. Как твоё имя?");
            string name = Console.ReadLine();
            Console.WriteLine("Введи текущий год:");
            int nowyear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введи текущий месяц:");
            int nowmonth;
            do
            {
                nowmonth = Convert.ToInt32(Console.ReadLine());
                if(nowmonth > 12 || nowmonth < 1)
                    Console.WriteLine("Вы ввели неверное значение.\nПопробуйте ещё раз.");
            }
            while (nowmonth > 12 || nowmonth < 1);


            Console.WriteLine("Введи текущий день:");
            int nowday;
            if(nowmonth == 1 || nowmonth == 3 || nowmonth == 5 || nowmonth == 7 || nowmonth == 8 || nowmonth == 10 || nowmonth == 12)
            {
                do
                {
                    nowday = Convert.ToInt32(Console.ReadLine());
                    if(nowday > 31 || nowday < 1)
                        Console.WriteLine("Вы ввели неверное значение.\nПопробуйте ещё раз.");
                }
                while (nowday > 31 || nowday < 1);
            }    
            else if(nowmonth == 4 || nowmonth == 6 || nowmonth == 9 || nowmonth == 11)
            {
                do
                {
                    
                    nowday = Convert.ToInt32(Console.ReadLine());
                    if(nowday > 30 || nowday < 1)
                        Console.WriteLine();
                }
                while (nowday > 30 || nowday < 1);

            }
            else
            {
                do
                {
                    nowday = Convert.ToInt32(Console.ReadLine());
                    if(nowday > 29 || nowday < 1)
                        Console.WriteLine("Вы ввели неверное значение.\nПопробуйте ещё раз.");
                }
                while (nowday > 29 || nowday < 1);
            }

           
           
            Console.WriteLine("Введи год рождения:");
            int yearDr;
            do
            {
                yearDr = Convert.ToInt32(Console.ReadLine());
                if(yearDr > nowyear)
                    Console.WriteLine("Введённый Вами год превышает текущий.\nПопробуйте ещё раз.");
            }
            while (yearDr > nowyear);
           
            Console.WriteLine("Введи месяц рождения:");
            int monthDr;
            do
            {
                monthDr = Convert.ToInt32(Console.ReadLine());
               
                if (monthDr > 12 || monthDr < 1)
                {
                    Console.WriteLine("Вы ввели неверный месяц!\nВведите ещё раз.");
                }
            }
            while (monthDr > 12 || monthDr < 1);
            Console.WriteLine("Введи день своего рождения:");
            int denDr = 0;
            if(monthDr == 1 || monthDr == 3 ||monthDr == 5 ||monthDr == 7 || monthDr == 8 ||monthDr == 10 || monthDr == 12) 
            {
                do
                {
                    denDr = Convert.ToInt32(Console.ReadLine());
                    if(denDr > 31 || denDr < 1) 
                        Console.WriteLine("Вы ввели неверный день!\nПопробуйте ещё раз.");
                }
                while (denDr > 31 || denDr < 1);
            }
            else if(monthDr == 4 || monthDr == 6 || monthDr == 9 || monthDr == 11)
            {
                do
                {
                    denDr = Convert.ToInt32(Console.ReadLine());
                    if(denDr > 30 || denDr < 1)
                        Console.WriteLine("Вы ввели неверный день!\nПопробуйте ещё раз.");
                }
                while (denDr > 30 || denDr < 1);

            }
            else if(monthDr == 2)
            {
                do
                {
                    denDr = Convert.ToInt32(Console.ReadLine());
                    if(denDr > 29 || denDr < 1)
                        Console.WriteLine("Вы ввели неверный день!\nПопробуйте ещё раз.");
                }
                while (denDr > 29 || denDr < 1);
            }
            int razngod = nowyear - yearDr;
            if (monthDr > nowmonth)
                razngod--;
            else if (monthDr == nowmonth)
            {
                if (denDr > nowday)
                    razngod--;
            }
                
            Console.WriteLine($"Здравствуй,{name}, тебе {razngod} лет. ");
            
            


            



        }
    }
}
