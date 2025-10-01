This repository contains two C# console applications demonstrating **Design Patterns**, **OOP concepts**, and **SOLID principles**:

1. **Exercise1 - Design Patterns Demo Project**
2. **Exercise2 - Smart Home System Simulation**

---

# **Exercise1 - Design Patterns Demo Project**

## Project Overview

This project demonstrates **commonly used software design patterns** in C#, covering **Creational, Structural, and Behavioral patterns**.

* Each pattern is implemented in a **separate folder**.
* Each class is in a **separate file** for clarity.
* Each folder contains a **Program.cs** (or demo class) to run the pattern.
* Ideal for **learning, interviews, and reference**.

## Creational Patterns

### Builder Pattern

**Purpose:** Construct complex objects step by step.

**Files:** `Invoice.cs`, `InvoiceBuilder.cs`, `Program.cs`, `Builder.csproj`

**Usage:** Run `Program.cs` to see step-by-step construction of invoices.

### Factory Method Pattern

**Purpose:** Create objects without exposing instantiation logic.

**Files:** `IPayment.cs`, `CreditCardPayment.cs`, `PayPalPayment.cs`, `BankTransferPayment.cs`, `PaymentFactory.cs`, `Program.cs`, `Factory_method.csproj`

**Usage:** Run `Program.cs` to dynamically create and use different payment methods.

## Structural Patterns

### Decorator Pattern

**Purpose:** Dynamically adds responsibilities to objects.

**Files:** `ICoffee.cs`, `SimpleCoffee.cs`, `CoffeeDecorator.cs`, `MilkDecorator.cs`, `SugarDecorator.cs`, `Program.cs`, `Decorator.csproj`

**Usage:** Run `Program.cs` to see coffee decorated dynamically with milk and sugar.

### Facade Pattern

**Purpose:** Provides a simplified interface to a complex subsystem.

**Files:** `DVDPlayer.cs`, `Projector.cs`, `SoundSystem.cs`, `Lights.cs`, `HomeTheaterFacade.cs`, `Program.cs`, `Facade.csproj`

**Usage:** Run `Program.cs` to control the home theater system via a single interface.

### Flyweight Pattern

**Purpose:** Reduces memory usage by sharing similar objects.

**Files:** `Shape.cs`, `Circle.cs`, `ShapeFactory.cs`, `FlyweightDemo.cs`, `Flyweight.csproj`

**Usage:** Run `FlyweightDemo.cs` to create multiple shared circle objects efficiently.

## Behavioral Patterns

### Memento Pattern

**Purpose:** Captures and restores object state without exposing internals.

**Files:** `TextEditor.cs`, `TextMemento.cs`, `Caretaker.cs`, `Program.cs`, `Memento.csproj`

**Usage:** Run `Program.cs` to perform undo/redo operations.

### Observer Pattern

**Purpose:** Defines a one-to-many dependency; observers are notified automatically.

**Files:** `College.cs`, `Student.cs`, `IObserver.cs`, `ISubject.cs`, `Program.cs`, `Observer.csproj`

**Usage:** Run `Program.cs` to simulate a college notification system.

---

## Exercise2 - Smart Home System Simulation

A **C# Console Application** simulating a Smart Home System where users control smart devices, schedule tasks, and automate triggers.

### Key Features

1. **Device Control:** Turn devices ON/OFF (Light, AC, HomeCleaner, Camera, DoorLock) with DoorLock secured via **Proxy Pattern**.
2. **Scheduling:** Schedule devices at specific times.
3. **Automation & Triggers:** **Observer Pattern** triggers devices automatically (Thermostat → AC, Door unlocked → Camera).
4. **Status Reporting:** Shows current device statuses and scheduled tasks.
5. **Dynamic Device Management:** Add/remove devices using **Factory Method**.

### Design Patterns Used

| Pattern        | Usage                                         |
| -------------- | --------------------------------------------- |
| Factory Method | `DeviceFactory` creates devices               |
| Observer       | Devices notify other devices automatically    |
| Proxy          | `DoorLockProxy` restricts unauthorized access |
| Singleton      | `SmartHub` ensures a single hub instance      |

### SOLID Principles Applied

| Principle | Usage                                                            |
| --------- | ---------------------------------------------------------------- |
| SRP       | Each class has a single responsibility                           |
| OCP       | Adding new devices/automation does not modify existing code      |
| LSP       | Devices inherit `DeviceBase` and can be substituted              |
| ISP       | Interfaces are lean: `ISmartDevice`, `IDeviceProxy`, `IObserver` |
| DIP       | `SmartHub` depends on abstractions                               |

### OOP Concepts Applied

* **Encapsulation:** Device properties are private/protected with getters/setters
* **Abstraction:** `ISmartDevice` and `DeviceBase` define common behavior
* **Inheritance:** `DeviceBase` → Light, Thermostat, DoorLock, AC, Camera, HomeCleaner
* **Polymorphism:** `SmartHub` manages devices via `ISmartDevice`

### User Inputs

| Input                                          | Action                     |
| ---------------------------------------------- | -------------------------- |
| `turnOn(<DeviceID>)`                           | Turns device ON            |
| `turnOff(<DeviceID>)`                          | Turns device OFF           |
| `setTemperature(<ThermostatID>, <Temp>)`       | Set thermostat temperature |
| `unlock(<DoorLockID>, <PIN>)`                  | Unlock door via Proxy      |
| `schedule(<DeviceID>, <Time>, turnOn/turnOff)` | Schedule device actions    |
| `showStatus()`                                 | Show device status         |
| `runSchedule(<CurrentTime>)`                   | Execute scheduled tasks    |

### Sample Simulation Flow

```
Thermostat temperature set to 70°C
SmartHub: Notifying observers...
AC: Temperature is high → AC turned ON

Door unlocked
SmartHub: Notifying observers...
DoorSensorCamera: Recording started

Schedule HomeCleaner at 07:00
HomeCleaner: Morning shift started

Show status
Light 1: OFF
Thermostat 2: 82°C
DoorLock 3: UNLOCKED
AC 4: ON
DoorSensorCamera 5: ON
HomeCleaner 6: ON
```

### Logging & Validation

* Actions, scheduling, and triggers logged via `Logger.cs`
* Input validated via `Validator.cs`

### How to Run

1. Open the solution in Visual Studio.
2. Build the solution.
3. Run `Program.cs` → interact with the menu.
4. Add devices, schedule tasks, and observe automation triggers.

### Future Enhancements

* Add motion/environment sensors
* Integrate voice commands or remote control
* Expand scheduling for recurring/multi-day automation
