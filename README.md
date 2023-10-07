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

Run the application, and it will simulate the behavior of various ducks, printing their respective quacking sounds and a total count of the number of quacks at the end.

## 🌱 Future Enhancements

- Introduce more types of ducks.
- Enhance with more design patterns like observer for monitoring quacking behaviors.
- Include a visual representation or GUI for a more interactive experience.

## 👥 Contributing

If you'd like to contribute, please fork the repository and use a feature branch. Pull requests are warmly welcome.

## ⚖️ Licensing

The code in this project is licensed under MIT license.
