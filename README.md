# 🦆 Duck Simulator

## 📜 Description

The Duck Simulator is a C# application that demonstrates the use of design patterns and principles such as compound patterns, adapter patterns, and factory patterns. This application creates different types of duck objects that can quack (or equivalent noises). It provides a way to simulate the quacking behavior of these ducks and count the number of times they quack.

## 🌟 Main Features

- **🏭 Duck Factory**: Provides the ability to create different types of duck objects.
- **🔢 Quack Counter**: Decorates any duck object to count the number of times it quacks.
- **🔌 Goose Adapter**: Demonstrates the adapter pattern by making a goose behave like a duck (a quackable entity).
- **🛠️ Abstract Factory Pattern**: Ensures that the ducks are created through a factory, allowing flexibility in their creation (like counting or not counting their quacks).

## 📚 Classes

### Program

- **Main()**: Entry point for the application. Initiates the simulation.
- **Simulate()**: Demonstrates the creation of various ducks using the duck factory and simulates their quacking.
- **Simulate(IQuackable duck)**: Helper method to simulate a specific duck's quack.

### QuackCounter

- **Quack()**: Quacks and increments the quack counter.
- **GetNumberOfQuacks()**: Static method to get the number of quacks across all decorated ducks.

### IQuackable

An interface representing any entity that can quack.

### GooseAdapter

An adapter that makes a goose quackable by converting its honk to a quack.

### Goose

A simple class representing a goose with a honk behavior.

### DuckFactory & CountingDuckFactory

Factories for creating different types of ducks. The `CountingDuckFactory` wraps the ducks in a `QuackCounter` to count their quacks.

### AbstractDuckFactory

An abstract factory class ensuring that all duck factories can create the required types of ducks.

### Various Duck Types

- **RubberDuck**: Quacks with a "Squeak".
- **RedHeadDuck**: Standard quacking.
- **MallardDuck**: Standard quacking.
- **DuckCall**: Produces a "Kwak".

## 🚀 Usage

To use the Duck Simulator, follow these steps:

1. Clone this repository to your local machine.
2. Open the solution in Visual Studio or your preferred C# IDE.
3. Build and run the application.

Upon running the application, it will display a menu with options to simulate the behavior of various ducks:

- **1) Simulate Mallard Duck**: Simulates a Mallard duck's quacking behavior.
- **2) Simulate RedHead Duck**: Simulates a RedHead duck's quacking behavior.
- **3) Simulate Duck Call**: Simulates a Duck Call's quacking behavior.
- **4) Simulate Rubber Duck**: Simulates a Rubber Duck's quacking behavior.
- **5) Simulate Goose Duck**: Simulates a Goose that behaves like a duck (adapter pattern).
- **6) Quit**: Exits the program.

After selecting an option, the application will display the duck's quacking behavior, increment the quack counter (if applicable), and provide an option to continue or return to the main menu. The total number of quacks across all ducks is displayed at the end of the simulation.

## 🌱 Future Enhancements

Here are some potential future enhancements for the Duck Simulator:

- Introduce additional types of ducks with unique quacking behaviors.
- Enhance the program with more design patterns, such as the observer pattern, to monitor and react to quacking behaviors dynamically.
- Implement a graphical user interface (GUI) for a more interactive and user-friendly experience.
