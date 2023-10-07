using System;
using compound;

namespace compound
{
    class Program
    {
        static void Main(string[] args) {
            Simulate();
        }

        static void Simulate() {
            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            IQuackable mallerdDuck = duckFactory.CreateMallardDuck();
            IQuackable redHeadDuck = duckFactory.CreateRedHeadDuck();
            IQuackable duckCall = duckFactory.CreateDuckCall();
            IQuackable rubberDuck = duckFactory.CreateRubberDuck();
            IQuackable gooseDuck = new GooseAdapter(new Goose());

            System.Console.WriteLine("Duck Simulator");
            Simulate(mallerdDuck);
            Simulate(redHeadDuck);
            Simulate(duckCall);
            Simulate(rubberDuck);
            Simulate(gooseDuck);

            System.Console.WriteLine("The ducks quacked " + QuackCounter.GetNumberOfQuacks() + " times");
        }

        static void Simulate(IQuackable duck) {
            duck.Quack();
        }
    }
}

