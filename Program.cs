using System;

namespace compound
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDuckFactory duckFactory = new CountingDuckFactory();
            IQuackable mallerdDuck = duckFactory.CreateMallardDuck();
            IQuackable redHeadDuck = duckFactory.CreateRedHeadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable goose = new GooseAdapter(new Goose());

            while (true)
            {
                ShowMenu();
                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Simulate(mallerdDuck);
                            break;
                        case 2:
                            Simulate(redHeadDuck);
                            break;
                        case 3:
                            Simulate(duckCall);
                            break;
                        case 4:
                            Simulate(rubberDuck);
                            break;
                        case 5:
                            Simulate(goose);
                            break;
                        case 6:
                            Environment.Exit(0); // Exit the program
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }

        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine($"Current quacks: {QuackCounter.GetNumberOfQuacks()}");
            Console.WriteLine("Duck Simulator Menu");
            Console.WriteLine("\t1) Simulate Mallard Duck");
            Console.WriteLine("\t2) Simulate RedHead Duck");
            Console.WriteLine("\t3) Simulate Duck Call");
            Console.WriteLine("\t4) Simulate Rubber Duck");
            Console.WriteLine("\t5) Simulate Goose");
            Console.WriteLine("\t6) Quit");
            Console.Write("Enter your choice (1-6): ");
        }

        static void Simulate(IQuackable duck)
        {
            Console.Clear();
            if (duck is GooseAdapter) {
                Console.WriteLine("Goose is not a duck, so no new quack.");
            }
            else {
                duck.Quack();
                Console.WriteLine("The ducks quacked " + QuackCounter.GetNumberOfQuacks() + " times");
            }
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
