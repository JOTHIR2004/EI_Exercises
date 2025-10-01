# Devices Folder

Contains **concrete smart device implementations**.

### Files:

- `Light.cs` → Smart Light
- `Thermostat.cs` → Smart Thermostat
- `DoorLock.cs` → Smart DoorLock
- `AC.cs` → Smart Air Conditioner
- `DoorSensorCamera.cs` → Camera attached to DoorLock
- `HomeCleaner.cs` → Smart HomeCleaner with scheduled shifts

### Key Concepts Applied:

- **OOP:** Inheritance (all devices inherit from `DeviceBase`), Polymorphism (SmartHub treats all devices via `ISmartDevice`)
- **Behavioral Pattern:** Devices can act as Observers in some cases
- **SOLID Principles:** SRP, LSP
