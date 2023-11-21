using System;

namespace CarProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantierea/crearea a trei obiecte numite Ford, Opel si Volvo

            // Pentru Ford si Opel folosind constructorul care defineste toate cele 4 atribute
            Car Ford = new Car("Blue", "Ford", 200, 2022);
            Car Opel = new Car("Red", "Opel", 180, 2021);

            // Pentru Volvo folosind constructorul care defineste un singur atribut - name
            Car Volvo = new Car("Volvo");

            // Afisarea numelor, anului de fabricatie si apelarea metodei FullThrottle pentru fiecare obiect
            Console.WriteLine($"Numele pentru Ford: {Ford.Name}");
            Console.WriteLine($"Anul de fabricatie pentru Ford: {Ford.Year}");
            Ford.FullThrottle();
            Console.WriteLine();

            Console.WriteLine($"Numele pentru Opel: {Opel.Name}");
            Console.WriteLine($"Anul de fabricatie pentru Opel: {Opel.Year}");
            Opel.FullThrottle();
            Console.WriteLine();

            Console.WriteLine($"Numele pentru Volvo: {Volvo.Name}");
            // Anul de fabricatie nu este setat pentru Volvo, deci va fi 0
            Console.WriteLine($"Anul de fabricatie pentru Volvo: {Volvo.Year}");
            Volvo.FullThrottle();
        }
    }
}
