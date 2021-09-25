using System;

namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib, mis hinde kasutaja sai;
            //kui kasutaja sai "A", konsool kuvab "Suurepärane";
            //"B", kuvab "Väga hea!";
            //"C", kuvab "Hea!";
            //"D", kuvab "Rahuldav!";
            //"E", kuvab "Kasin";
            //"F", kuvab "Puudulik";
            //kui midagi muud "Vale väärtus";

            Console.WriteLine("Sisesta oma tulemus:");
            Char userResult = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (userResult)
            {
                case 'A':
                    Console.WriteLine("Suurepärane!");
                    break;
                case 'B':
                    Console.WriteLine("Väga hea!");
                    break;
                case 'C':
                    Console.WriteLine("Hea!");
                    break;
                case 'D':
                    Console.WriteLine("Rahuldav!");
                    break;
                case 'E':
                    Console.WriteLine("Kasin");
                    break;
                case 'F':
                    Console.WriteLine("Puudulik");
                    break;
                default:
                    Console.WriteLine("Vale väärtus!");
                    break;
            }
        }
    }
}
