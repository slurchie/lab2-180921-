using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1
            Console.WriteLine("A1.1");
            Console.Write("Введите количество n секунд: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a)количество часов: " + n / 3600);
            Console.WriteLine("b)количество минут с начала очередного часа: " + (n % 3600) / 60);
            Console.WriteLine("c)количество секунд с начала очередной минуты: " + (n % 60));
            //1.2
            Console.WriteLine("A1.2");
            Console.WriteLine("дан прямоугольник размером 543мм*130мм");
            Console.WriteLine("Количество квадратов размером 130 * 130= " + (543 * 130) / (130 * 130));
            //1.3
            Console.WriteLine("\n А1.3 \n Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            double newmonth;
            if (month > 12)
            {
                newmonth = month % 12 + 1; 
                                             
            }
            else // иначе если прошел ровно год то
            {
                if (month == 12)
                {
                    newmonth = 2; 
                }
                else
                {
                    newmonth = month + 1;
                }
            }
            Console.WriteLine($"Сейчас {newmonth} месяц");

            Console.WriteLine("\n A1.4 \n Введите число: ");
            int chislo;
            chislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число десятков=" + chislo / 10);
            Console.WriteLine("Число единиц=" + chislo % 10);
            Console.WriteLine("Сумма цифр=" + (chislo % 10 + chislo / 10));
            Console.WriteLine("Произведение цифр=" + ((chislo % 10) * (chislo / 10)));
            //1.3
            Console.WriteLine("\n A1.5 \n Введите трёхзначное число: ");
            chislo = Convert.ToInt32(Console.ReadLine());
            int result = (chislo % 100) * 10 + chislo / 100;
            Console.WriteLine("Полученное число = " + result);
            //
            Console.WriteLine("\n A1.6 \n Введите трёхзначное число: ");
            for (int cislo3 = 100; cislo3 < 1000; cislo3++)
            {
                if ((cislo3 % 10).ToString() + ((cislo3 - cislo3 % 10) / 10).ToString() == "237")
                {
                    Console.WriteLine($"Число - {cislo3}");
                    break;
                }
            }

            Console.WriteLine("\n A1.7 \n Введите первое двухзнчаное число: \n Введите второе двухзначное число:");
            int ch1 = Convert.ToInt32(Console.ReadLine());
            int ch2 = Convert.ToInt32(Console.ReadLine());
            result = (ch1/10 )+(ch1 % 10) + (ch2 % 10) + (ch2 / 10);
            Console.WriteLine("Получившаяся сумма цифр: " + result);
            Console.ReadLine();

            Console.WriteLine("\n A1.8 \n Введите число k: ");
            int k = Convert.ToInt32(Console.ReadLine());
            chislo = 100 + k / 3;
            Console.WriteLine("к кратно 3: {0}", chislo % 10);
            Console.WriteLine("к = 1, 4, 7... : {0}", chislo / 100);
            Console.WriteLine("к = 2, 5, 8: {0}", (chislo % 100) / 10);
           
            Console.WriteLine("A1.9");
            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine("a = {0}, б = {1}, в = {2}", A | B, A & B, B | C);

            Console.WriteLine("A1.10");
            bool X, Y, Z;
            X = true;Y = false;Z = false;
            Console.WriteLine("a={0}",!(X | Y) & (!X | !Z));
            Console.WriteLine("b = {0}", !(!X & Y) | (X & !Z));
            Console.WriteLine("c={0}", (X | !Y) & !(X | !Z));
            X = false;Y = true;Z = false;
            Console.WriteLine("a = {0}", !(X | Y) & (!X | !Z));
            Console.WriteLine("б = {0}", !(!X & Y) | (X & !Z));
            Console.WriteLine("в = {0}", X | !Y & !(X | !Z));
            X = true;Y = true;Z = true;
            Console.WriteLine("a = {0}", !(X | Y) & (!X | !Z));
            Console.WriteLine("б = {0}", !(!X & Y) | (X & !Z));
            Console.WriteLine("в = {0}", X | !Y & !(X | !Z));
            X = false;Y = false;Z = false;
            Console.WriteLine("a = {0}", !(X | Y) & (!X | !Z));
            Console.WriteLine("б = {0}", !(!X & Y) | (X & !Z));
            Console.WriteLine("в = {0}", X | !Y & !(X | !Z));
            X = false;Y = false;Z = true;
            Console.WriteLine("a = {0}", !(X | Y) & (!X | !Z));
            Console.WriteLine("б = {0}", !(!X & Y) | (X & !Z));
            Console.WriteLine("в = {0}", X | !Y & !(X | !Z));
            X = true;Y = false;Z = false;
            Console.WriteLine("a = {0}", !(X | Y) & (!X | !Z));
            Console.WriteLine("б = {0}", !(!X & Y) | (X & !Z));
            Console.WriteLine("в = {0}", X | !Y & !(X | !Z));

            Console.WriteLine("Дополнительное задание");
            Console.WriteLine("2.1");
            double flower1 = Convert.ToDouble(Console.ReadLine());
            double flower2 = Convert.ToDouble(Console.ReadLine());
            if ((flower1 % 2 == 0) && (flower2 % 2 != 0))
            {
                Console.WriteLine("Влюблены");
            }
            else
            {
                Console.WriteLine("Не влюблены");
            }

            Console.WriteLine("2.2");
            double time = Convert.ToDouble(Console.ReadLine());
            double litres = Math.Floor(time * 0.5);
            Console.WriteLine($"{litres}");
            Console.ReadLine();



        }
    }
}
