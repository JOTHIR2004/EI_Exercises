# Observer Pattern

## Purpose
The Observer Pattern defines a one-to-many dependency between objects. When the subject changes state, all registered observers are notified automatically.

## Files

- `College.cs` : Subject class that maintains a list of observers and posts notifications.
- `Student.cs` : Concrete observer that receives notifications.
- `IObserver.cs` : Observer interface defining the Update method.
- `ISubject.cs` : Subject interface defining Attach, Detach, and Notify methods.
- `Program.cs` : Entry point to run the Observer demo.
- `Observer.csproj` : Project file for the Observer pattern.

## Usage
Run `Program.cs` to simulate a college notification system where students subscribe/unsubscribe and receive announcements automatically.
