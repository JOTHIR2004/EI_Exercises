using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Caretaker
    {
        private Stack<TextMemento> undoStack = new Stack<TextMemento>();
        private Stack<TextMemento> redoStack = new Stack<TextMemento>();

        public void Save(TextMemento memento)
        {
            undoStack.Push(memento);
            redoStack.Clear();
        }

        public TextMemento Undo()
        {
            if (undoStack.Count == 0) return null;
            TextMemento memento = undoStack.Pop();
            redoStack.Push(memento);
            return memento;
        }

        public TextMemento Redo()
        {
            if (redoStack.Count == 0) return null;
            return redoStack.Pop();
        }
    }
}
