# Smart Home System Simulation

A **C# Console Application** simulating a Smart Home System where users can control various smart devices, schedule tasks, and automate triggers. The system demonstrates **OOP principles**, **SOLID design**, and **Design Patterns** including **Observer**, **Factory Method**, **Proxy**, and **Singleton**.

---

## Key Features

1. **Device Control**
   - Turn devices ON/OFF (Light, AC, HomeCleaner, Camera, DoorLock)
   - DoorLock secured via **Proxy Pattern** (PIN-based authorization)

2. **Scheduling**
   - Schedule HomeCleaner or any device to run at specific times
   - Execute scheduled tasks based on current time

3. **Automation & Triggers**
   - **Observer Pattern**: Devices react to other devices automatically  
     Example: Thermostat > 70°F → AC turns ON  
              Door unlocked → DoorSensorCamera turns ON  

4. **Status Reporting**
   - Show the current status of all devices
   - View scheduled tasks and active triggers

5. **Dynamic Device Management**
   - Add or remove devices at runtime using the **Factory Method**

---

## Design Patterns Used

| Pattern | Usage |
|---------|-------|
| **Factory Method** | `DeviceFactory` creates devices based on type |
| **Observer**       | Thermostat and DoorLock notify AC and Camera |
| **Proxy**          | `DoorLockProxy` restricts unauthorized access |
| **Singleton**      | `SmartHub` ensures a single central hub instance |

---

## SOLID Principles Applied

| Principle | Usage |
|-----------|-------|
| **SRP**  | Each class handles a single responsibility (device state, scheduling, logging) |
| **OCP**  | Adding new devices or automation does not modify existing code |
| **LSP**  | Devices inherit `DeviceBase` and can be substituted in `SmartHub` |
| **ISP**  | Interfaces are lean: `ISmartDevice`, `IDeviceProxy`, `IObserver` |
| **DIP**  | `SmartHub` depends on abstractions (`ISmartDevice`) instead of concrete classes |

---

## OOP Concepts Applied

- **Encapsulation:** Device properties are private/protected with getters/setters  
- **Abstraction:** `ISmartDevice` and `DeviceBase` define common behavior  
- **Inheritance:** `DeviceBase` → Light, Thermostat, DoorLock, AC, Camera, HomeCleaner  
- **Polymorphism:** `SmartHub` manages devices through `ISmartDevice`  

---

## User Inputs

Users interact via **console menu**:

| Input | Action |
|-------|--------|
| `turnOn(<DeviceID>)` | Turns a device ON |
| `turnOff(<DeviceID>)` | Turns a device OFF |
| `setTemperature(<ThermostatID>, <Temp>)` | Set thermostat temperature |
| `unlock(<DoorLockID>, <PIN>)` | Unlock DoorLock via Proxy |
| `schedule(<DeviceID>, <Time>, turnOn/turnOff)` | Schedule device actions |
| `showStatus()` | Show status of all devices |
| `runSchedule(<CurrentTime>)` | Run scheduled tasks |

---

## Sample Simulation Flow

Thermostat temperature set to 70°F
SmartHub: Notifying observers...
AC: Temperature is high → AC turned ON

Door unlocked
SmartHub: Notifying observers...
DoorSensorCamera: Recording started

Schedule HomeCleaner at 07:00
HomeCleaner: Morning shift started

## Show status

Light 1: OFF
---
Thermostat 2: 75°F
---
DoorLock 3: UNLOCKED
---
AC 4: ON
---
DoorSensorCamera 5: ON
---
HomeCleaner 6: ON
---

## Logging & Validation

- All device actions, scheduling, and triggers are logged via `Logger.cs`  
- User inputs are validated via `Validator.cs` to prevent invalid operations  

---

## How to Run

1. Open the solution in Visual Studio or your preferred IDE.
2. Build the solution.
3. Run `Program.cs` → interact with the menu for device control.
4. Add custom devices, schedule tasks, and observe automation triggers.
---
