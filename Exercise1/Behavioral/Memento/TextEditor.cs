using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextEditor
    {
        public string Content { get; set; }

        public TextMemento Save() => new TextMemento(Content);

        public void Restore(TextMemento memento)
        {
            Content = memento.Content;
        }
    }
}
