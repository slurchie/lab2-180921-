using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodichka180921
{
    enum bankaccount
    {
            sber=2000,
            tek = 5000
     }
    struct chet
    {
        public string number;
        public string type;
        public string balans;

        public void WriteUserInfo()
        {
            Console.WriteLine("Номер: {0},Тип: {1}, Баланс: {2}", number,type,balans);
        }
    }
    struct univercity
    {
        public string univer;
        public string name;
        public void result()
        {
            Console.WriteLine("Имя: {0},Университет: {1}", name, univer);
        }
    }
    class Program
    {
        static void Main(string[] args )
        {
            //3.1
            Console.WriteLine("3.1");
            bankaccount amount1, amount2;
            amount1 = bankaccount.sber;
            amount2 = bankaccount.tek;
            Console.WriteLine($"сберегательный счёт - {(int)amount1}");
            Console.WriteLine($"текущий счёт - {(int)amount2}");

            //3.2
            Console.WriteLine("3.2");
            chet info;
            info.number = "первый";
            info.type = "сберегательный";
            info.balans = "20";
            Console.Write("информация по счёту: ");
            info.WriteUserInfo();

            //дз3.1
            Console.WriteLine("дз3.1");
            univercity stud1;
            stud1.name = "Людмурик";
            stud1.univer = "КФУ";
            Console.Write("студент 1: ");
            stud1.result();

            univercity stud2;
            stud2.name = "Илья";
            stud2.univer = "КХТИ";
            Console.Write("студент 2: ");
            stud2.result();

            univercity stud3;
            stud3.name = "Биба";
            stud3.univer = "КАИ";
            Console.Write("студент 3 ");
            stud3.result();


        }
    }
    }

