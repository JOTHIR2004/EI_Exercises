### Memento Pattern  

**Purpose:**  
The Memento Pattern is used to capture and restore an object's internal state without exposing its details. Ideal for undo/redo functionality.  

**Files:**  
- `Caretaker.cs` : Manages saved states and supports undo/redo functionality.  
- `TextEditor.cs` : Originator class holding the current text content.  
- `TextMemento.cs` : Memento class storing a snapshot of the text.  
- `Program.cs` : Entry point to run the Memento demo.  
- `Memento.csproj` : Project file for the Memento pattern.  

**Usage:**  
Run `Program.cs` to see a demo of saving text states, performing undo/redo operations, and restoring previous versions.  

