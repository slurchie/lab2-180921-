using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork180921
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("задание 1");
            string sb = "sbyte";
            Console.WriteLine(sb + $"[{sbyte.MinValue},{sbyte.MaxValue}]");
            string b = "byte";
            Console.WriteLine(b + $"[{byte.MinValue}, {byte.MaxValue}]");
            string sh = "short";
            Console.WriteLine(sh + $"[{short.MinValue},{short.MaxValue}]");
            string us = "ushort";
            Console.WriteLine(us + $"[{ushort.MinValue}+{ushort.MaxValue}]");
            string nti = "int";
            Console.WriteLine(nti + $"[{int.MinValue},{int.MaxValue}]");
            string ui = "uint";
            Console.WriteLine(ui + $"[{uint.MinValue},{uint.MaxValue}]");
            string flt = "float";
            Console.WriteLine(flt + $"[{float.MinValue}, {float.MaxValue}]");
            string dbl = "double";
            Console.WriteLine(dbl + $"[{double.MinValue},{double.MaxValue}]]");
            string dcml = "decimal";
            Console.WriteLine(dcml + $"[{decimal.MinValue},{decimal.MaxValue}]");
            string chr = "char";
            Console.WriteLine(chr + $"[{char.MinValue},{char.MinValue}]");
            string lng = "int64";
            Console.WriteLine(lng + $"[{Int64.MinValue},{Int64.MaxValue}]");
            string ulng = "uint64";
            Console.WriteLine(ulng + $"[{UInt64.MinValue},{UInt64.MaxValue}]");

            Console.WriteLine("задание 2");
            Console.Write("Введите имя: ");
            string imya = Console.ReadLine();
            Console.Write("Введите город: ");
            string gorod = Console.ReadLine();
            Console.Write("Введите возраст: ");
            double vzrst = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите пинкод: ");
            double pincode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" имя: " + imya + " город: " + gorod + "  возраст: " + vzrst + " пинкод: " + pincode);


            Console.WriteLine("\nзадание 3\nВведите строку: ");
            string origLine = Console.ReadLine();
            string newLine = "";
            foreach (var c in origLine)  
            {
                if (char.IsLower(c))
                    newLine += char.ToUpper(c);
                else
                    newLine += char.ToLower(c);
            }
            Console.WriteLine("Преобразованная строка: {0}", newLine);


            Console.WriteLine("\nзадание 4\nВведите строку: ");
            string str = Console.ReadLine();  
            Console.WriteLine("Введите подстроку: ");
            string substr = Console.ReadLine(); 
            int count = (str.Length - str.Replace(substr, "").Length) / substr.Length;
            Console.WriteLine("Количество вхождений: {0}", +count);


            Console.WriteLine("\nзадание 5\nВведите скорость таракана в км/ч:");
            double trkskr = Convert.ToDouble(Console.ReadLine());
            trkskr *= 1000 / 36;
            Console.WriteLine($"{(int)trkskr}см/с");


            Console.WriteLine("\nзадание 6\nВведите возраст отца:");
            int dadAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите возраст сына:");
            int sonAge = Convert.ToInt32(Console.ReadLine());
            if (dadAge <= sonAge)
                Console.WriteLine("Некорректные значения");
            else
            {
                int diffAge = dadAge - sonAge;  
                if (diffAge < sonAge)
                    Console.WriteLine($"Отец был старше сына в 2 раза {sonAge - diffAge} лет назад");
                else
                {
                    if (diffAge == sonAge)
                        Console.WriteLine("Отец старше сына в 2 раза");
                    else
                        Console.WriteLine($"Отец будет старше сына в 2 раза через {diffAge - sonAge} лет");
                }
            }
            Console.WriteLine("\nзадание 7\nВведите стандартную цену бутылки:");
            int normprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скидку в DutyFree:");
            int saleprice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска:");
            int holidayprice = Convert.ToInt32(Console.ReadLine());
            int bottleNumber = holidayprice / (normprice * saleprice / 100);
            Console.WriteLine("Количество бутылок для окупаемости отпуска: {0}", bottleNumber);
            Console.ReadKey();














        }
    }
}
