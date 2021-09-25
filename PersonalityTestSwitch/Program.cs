using System;

namespace PersonalityTestSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt tema lemmik värvi
            //kui kasutaja sisestab "punane" konsool kuvab "oled romantiline"
            //kui kasutaja sisestab "sinine" konsoon kuvb "oled töökas"
            //kui kasutaja sisestab "roheline" kuvab "oled looduse sõber"
            //kui sisestab midagi muud konsool kuvab "oled {userColor} ükssarvik"

            Console.WriteLine("Sisest oma lemmikvärv:");
            string userColor = Console.ReadLine().ToLower();

            switch (userColor)
            {
                case "punane":
                    Console.WriteLine("Oled romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber");
                    break;
                default:
                    Console.WriteLine($"Oled {userColor} ükssarvik.");
                    break;
            }

            Console.WriteLine("Kena päeva");

        }
    }
}
