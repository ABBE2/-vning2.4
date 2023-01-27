using System;

namespace övning2._4
{

    class övning2_4
    {

        static void Main(string[] args)
        {

            Console.WriteLine("På ett företag finns det tre anställda, vad är detras månadslön?");
            Console.Write("Person1: ");
            string lön1text = Console.ReadLine();
            Console.Write("person2: ");
            string lön2text = Console.ReadLine();
            Console.Write("Person3: ");
            string lön3text = Console.ReadLine();

            double lön1 = double.Parse(lön1text);
            double lön2 = double.Parse(lön2text);
            double lön3 = double.Parse(lön3text);

            double medellön = ((lön1 + lön2 + lön3) / 3);

            Console.WriteLine("Medellönen i företaget blir " + medellön + "kr");

        }

    }

}