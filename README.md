# Exercise 1: Design Patterns  

This project demonstrates common **Design Patterns** in C#, covering **Creational, Structural, and Behavioral patterns**.  

## Creational Patterns  
### Builder Pattern  
- Builds complex objects step by step.  
- **Use Case**: Invoice creation with optional details.  

### Factory Method Pattern  
- Creates objects without exposing instantiation logic.  
- **Use Case**: Payment gateway (Credit Card, PayPal, Bank Transfer).  

## Structural Patterns  
### Decorator Pattern  
- Dynamically adds responsibilities to objects.  
- **Use Case**: Coffee customization with milk and sugar.  

### Facade Pattern  
- Provides a simplified interface to a subsystem.  
- **Use Case**: Home Theater system (DVD, Projector, Sound System, Lights).  

## Behavioral Patterns  
### Memento Pattern  
- Captures/restores object state.  
- **Use Case**: Text editor undo/redo.  

### Observer Pattern  
- Defines one-to-many dependency between objects.  
- **Use Case**: College notification system (Students auto-notified).  

---

# Exercise 2: Smart Home System Simulation  

A C# Console Application simulating a **Smart Home System** with device control, scheduling, and automation.  

## Key Features  
- Turn devices ON/OFF (Light, AC, DoorLock, Camera, Cleaner).  
- Schedule tasks for devices.  
- Automation via Observer (Thermostat → AC, Door unlock → Camera).  
- DoorLock secured with Proxy.  
- Single hub using Singleton.  

## Design Patterns Used  
- **Factory Method** – Device creation.  
- **Observer** – Device triggers.  
- **Proxy** – Secured DoorLock.  
- **Singleton** – Central SmartHub.  

## How to Run  
1. Open Visual Studio.  
2. In Exercise2, open the `Smart_Home_System` folder as a project/solution.  
3. Build and run the `Program.cs` file inside `Smart_Home_System`.  
4. Use commands like:  
   - `turnOn(<DeviceID>)`  
   - `schedule(<DeviceID>, <Time>, turnOn/turnOff)`  
   - `showStatus()`   


## Sample Flow  
- Thermostat hits 70°F → AC turns ON.  
- Door unlocked → Camera starts recording.  
- Cleaner scheduled at 07:00 → Auto starts.  
