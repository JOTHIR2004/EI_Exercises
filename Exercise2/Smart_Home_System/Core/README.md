# Core Folder

Contains the **base abstractions, factory methods, and proxies** for the Smart Home System.

### Files:

- `ISmartDevice.cs` → Base interface for all devices
- `DeviceBase.cs` → Abstract base class implementing common properties & methods
- `DeviceFactory.cs` → Factory Method to create devices dynamically
- `IDeviceProxy.cs` → Proxy interface
- `DoorLockProxy.cs` → Proxy implementation for DoorLock access control

### Key Concepts Applied:

- **OOP:** Abstraction, Encapsulation, Inheritance
- **Design Patterns:** Factory Method, Proxy
- **SOLID Principles:** SRP, OCP, LSP, DIP
