namespace Memento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Memento Pattern Demo ===");

            TextEditor editor = new TextEditor();
            Caretaker caretaker = new Caretaker();

            editor.Content = "Version 1";
            caretaker.Save(editor.Save());

            editor.Content = "Version 2";
            caretaker.Save(editor.Save());

            editor.Content = "Version 3";
            caretaker.Save(editor.Save());

            Console.WriteLine($"Current Text: {editor.Content}");

            // Undo
            editor.Restore(caretaker.Undo());
            Console.WriteLine($"After Undo: {editor.Content}");

            editor.Restore(caretaker.Undo());
            Console.WriteLine($"After Undo: {editor.Content}");

            // Redo
            editor.Restore(caretaker.Redo());
            Console.WriteLine($"After Redo: {editor.Content}");

            Console.ReadKey();
        }
    }
}
