using System;

namespace Personalregister
{
    class Program
    {
        static Registry registry = new Registry();
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen!");
            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("Välj från menyn:");
            Console.WriteLine("(L)ägg till anställd");
            Console.WriteLine("(S)e över anställda");
            Console.WriteLine("(A)vsluta");
            UserInput();
        }


        // Läser av input från användaren
        private static void UserInput()
        {
            ConsoleKeyInfo keyBoardInput = Console.ReadKey(true);

            switch (keyBoardInput.Key)
            {
                case ConsoleKey.L:
                    Console.Clear();
                    AddEmployee();
                    break;
                case ConsoleKey.S:
                    Console.Clear();
                    ReadRegistry();
                    break;
                case ConsoleKey.A:
                    Console.Clear();
                    End();
                    break;
                default:
                    Console.Clear();
                    wrongInput();
                    break;
            }
        }

        // Kallar på fuktionen från klassen Registry, för att lägga till anställda i registret
        private static void AddEmployee()
        {
            try
            {
                Console.WriteLine("Ange namn: ");
                string name = Console.ReadLine();
                Console.WriteLine("Ange lön: ");
                int pay = Int32.Parse(Console.ReadLine());
                registry.AddToRegistry(name, pay);

                Console.Clear();
                Console.WriteLine("Anställd tillagd!");
                Console.WriteLine();
                Console.WriteLine("Vill du göra något mer?");
                Menu();
            }
            // för att fånga felatkig input (bokstäver istället för siffror som lön)
            catch (Exception e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
                Console.WriteLine("Vänlig ange korrekt information");
                AddEmployee();
            }
        }

        // läser av anställda i registret via Registry klassens funktion
        private static void ReadRegistry()
        {
            registry.ReadRegistry();
            Console.WriteLine("(T)illbaka");
            Console.WriteLine("(A)vsluta");

            ConsoleKeyInfo keyBoardInput = Console.ReadKey(true);
            switch (keyBoardInput.Key)
            {
                case ConsoleKey.T:
                    Console.Clear();
                    Menu();
                    break;
                case ConsoleKey.A:
                    Console.Clear();
                    End();
                    break;
                default:
                    Console.Clear();
                    wrongInput();
                    break;
            }
            
        }

        private static void wrongInput()
        {
            Console.WriteLine("Ogiltig inmatning.");
            Menu();
        }

        private static void End()
        {
            Console.WriteLine("Välkommen åter!");
        }
    }
}
