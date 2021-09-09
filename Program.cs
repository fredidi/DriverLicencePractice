using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input, age14, age15, age16, age17, age18, age19, age21, age23, thankYou;

            age14 = "- Moped klass I (EU-moped).";
            age15 = "- Lätt motorcykel.";
            age16 = "- Personbil.";
            age17 = "- Tung motorcykel. Personbil med lätt släpvagn. Lätt lastbil.";
            age18 = "- Personbil med tungt släp. Lastbil med tungt släp. Tung motorcykel.";
            age19 = "- Tung motorcykel (om du haft körkort för medelstor motorcykel i minst 1 år och 6 månader).";
            age21 = "- Buss och Buss med släp.";
            age23 = "- Tung motorcykel med obegränsad effekt (i trafikskola 17 år och 6 månader).";
            //Tack meddelande
            thankYou = "\nTack för att du använde tjänsten. Ha en bra dag.";


            Console.WriteLine("Välkommen.\nMata in din ålder [ÅR] så får du se vilken/vilka fordonstyp som du får övningsköra.");
            Console.Write("Ange din ålder: ");
            int age = 0;
            input = Console.ReadLine();

            while (!int.TryParse(input, out age))
            {
                Console.Write("\nFelaktigt format. Vänligen försök igen. Ange din ålder i hela siffror: ");
                input = Console.ReadLine();
            }

            //Minderårig
            if (age <= 13)
            {
                Console.WriteLine("\nDu är " + age + " år gammal. Du får tyvärr inte övningsköra än.\n" + thankYou);
            }

            //Från 14 år 9 mån
            else if (age == 14)
            {
                Console.WriteLine("\nDu är " + age + " år gammal. Du får övningsköra följande:");
                Console.WriteLine(age14 + "\n" + thankYou);
            }

            //Från 15 år 9 månader
            else if (age == 15)
            {
                Console.WriteLine("\nDu är " + age + " år gammal. Du får övningsköra följande:");
                Console.WriteLine(age14 + "\n" + age15 + "\n" + thankYou);
            }

            //Från 16 år
            else if (age == 16)
            {
                Console.WriteLine("\nDu är " + age + " år gammal. Du får övningsköra följande:");
                Console.WriteLine(age14 + "\n" + age15 + "\n" + age16 + "\n" + thankYou);
            }

            //Från 17 år 6 månader
            else if (age == 17)
            {
                Console.WriteLine("\nDu är " + age + " år gammal. Du får övningsköra följande:");
                Console.WriteLine(age14 + "\n" + age15 + "\n" + age16 + "\n" + age17 + "\n" + thankYou);
            }

            //Från 18 år
            else if (age == 18)
            {
                Console.WriteLine("\nDu är " + age + " år gammal. Du får övningsköra följande:");
                Console.WriteLine(age14 + "\n" + age15 + "\n" + age16 + "\n" + age17 + "\n" + age18 + "\n" + thankYou);
            }

            //Från 19 år 6 månader
            else if (age >= 19 && age <= 20)
            {
                Console.WriteLine("\nDu är " + age + " år gammal. Du får övningsköra följande:");
                Console.WriteLine(age14 + "\n" + age15 + "\n" + age16 + "\n" + age17 + "\n" + age18 + "\n" + age19 + "\n" + thankYou);
            }

            //Från 21 år
            else if (age >= 21 && age <= 22)
            {
                Console.WriteLine("\nDu är " + age + " år gammal. Du får övningsköra följande:");
                Console.WriteLine(age14 + "\n" + age15 + "\n" + age16 + "\n" + age17 + "\n" + age18 + "\n" + age19 + "\n" + age21 + "\n" + thankYou);
            }

            //Från 23 år
            else 
            {
                Console.WriteLine("\nDu är " + age + " år gammal. Du får övningsköra följande:");
                Console.WriteLine(age14 + "\n" + age15 + "\n" + age16 + "\n" + age17 + "\n" + age18 + "\n" + age19 + "\n" + age21 + "\n" + age23 + "\n" + thankYou);
            }

            Console.ReadKey();
        }
    }
}
