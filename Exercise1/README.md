# Exercise1 - Design Patterns Demo Project

## Project Overview

This project demonstrates **commonly used software design patterns** in C#, covering **Creational, Structural, and Behavioral patterns**.

* Each pattern is implemented in a **separate folder**.
* Each class is in a **separate file** for clarity.
* Each folder contains a **Program.cs** (or demo class) to run the pattern.
* Ideal for **learning, interviews, and reference**.

---

## Creational Patterns

### Builder Pattern

**Purpose:** Construct complex objects step by step, allowing different representations.

**Files:**

* `Invoice.cs` : The final product class.
* `InvoiceBuilder.cs` : Builder class defining steps to create the invoice.
* `Program.cs` : Entry point to run the Builder demo.
* `Builder.csproj` : Project file.

**Usage:** Run `Program.cs` to see step-by-step construction of invoices.

---

### Factory Method Pattern

**Purpose:** Defines an interface for creating objects but lets subclasses decide which class to instantiate.

**Files:**

* `IPayment.cs` : Interface for payment methods.
* `CreditCardPayment.cs`, `PayPalPayment.cs`, `BankTransferPayment.cs` : Concrete payment methods.
* `PaymentFactory.cs` : Factory to create payment objects.
* `Program.cs` : Entry point to run the Factory Method demo.
* `Factory_method.csproj` : Project file.

**Usage:** Run `Program.cs` to dynamically create and use different payment methods.

---

## Structural Patterns

### Decorator Pattern

**Purpose:** Dynamically adds responsibilities to objects without modifying them.

**Files:**

* `ICoffee.cs` : Component interface.
* `SimpleCoffee.cs` : Basic coffee implementation.
* `CoffeeDecorator.cs` : Base decorator.
* `MilkDecorator.cs`, `SugarDecorator.cs` : Concrete decorators.
* `Program.cs` : Entry point to run the Decorator demo.
* `Decorator.csproj` : Project file.

**Usage:** Run `Program.cs` to see how coffee objects are decorated dynamically with milk and sugar.

---

### Facade Pattern

**Purpose:** Provides a simplified interface to a complex subsystem.

**Files:**

* `DVDPlayer.cs`, `Projector.cs`, `SoundSystem.cs`, `Lights.cs` : Subsystem classes.
* `HomeTheaterFacade.cs` : Facade combining subsystems.
* `Program.cs` : Entry point to run the Facade demo.
* `Facade.csproj` : Project file.

**Usage:** Run `Program.cs` to control the home theater system using a single unified interface.

---

### Flyweight Pattern

**Purpose:** Reduces memory usage by sharing objects that are similar.

**Files:**

* `Shape.cs` : Flyweight interface.
* `Circle.cs` : Concrete flyweight.
* `ShapeFactory.cs` : Factory managing shared instances.
* `FlyweightDemo.cs` : Client demo.
* `Flyweight.csproj` : Project file.

**Usage:** Run `FlyweightDemo.cs` to create multiple circles efficiently using shared objects.

---

## Behavioral Patterns

### Memento Pattern

**Purpose:** Captures and restores object state without exposing internal structure.

**Files:**

* `TextEditor.cs` : Originator storing current text.
* `TextMemento.cs` : Memento class storing snapshots.
* `Caretaker.cs` : Manages undo/redo stack.
* `Program.cs` : Entry point to run the Memento demo.
* `Memento.csproj` : Project file.

**Usage:** Run `Program.cs` to see undo/redo operations on text editor content.

---

### Observer Pattern

**Purpose:** Defines a one-to-many dependency; all observers are notified automatically when the subject changes.

**Files:**

* `College.cs` : Subject class posting announcements.
* `Student.cs` : Concrete observer receiving notifications.
* `IObserver.cs` : Observer interface.
* `ISubject.cs` : Subject interface.
* `Program.cs` : Entry point to run the Observer demo.
* `Observer.csproj` : Project file.

**Usage:** Run `Program.cs` to simulate a college notification system where students subscribe/unsubscribe to announcements.

---

## Usage Instructions

1. Open the project in **Visual Studio**.
2. Navigate to the folder of the pattern you want to run.
3. Run the `Program.cs` file to see the pattern demo.
4. Observe console output for **pattern behavior in action**.

---

## Key Points

* **Creational patterns** → Object creation.
* **Structural patterns** → Object composition and relationships.
* **Behavioral patterns** → Object interaction and communication.
* Each pattern has a **demo program** to illustrate usage clearly.
