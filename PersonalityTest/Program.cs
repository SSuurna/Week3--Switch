using System;

namespace PersonalityTest
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
            string userColor = Console.ReadLine();

            if(userColor == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if(userColor == "sinine")
            {
                Console.WriteLine("Oled töökas.");
            }
            else if(userColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber.");
            }
            else
            {
                Console.WriteLine($"Oled {userColor} ükssarvik.");
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
