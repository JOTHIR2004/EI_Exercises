# Decorator Pattern

## Purpose
The Decorator Pattern dynamically adds responsibilities to objects without modifying their class. Ideal for extending functionality at runtime.

## Files

- `ICoffee.cs` : Component interface defining coffee operations.
- `SimpleCoffee.cs` : Concrete component implementing basic coffee.
- `CoffeeDecorator.cs` : Base decorator class that wraps a coffee object.
- `MilkDecorator.cs` : Concrete decorator adding milk to coffee.
- `SugarDecorator.cs` : Concrete decorator adding sugar to coffee.
- `Program.cs` : Entry point to run the Decorator demo.
- `Decorator.csproj` : Project file for the Decorator pattern.

## Usage
Run `Program.cs` to see a basic coffee decorated with milk and sugar dynamically at runtime.
