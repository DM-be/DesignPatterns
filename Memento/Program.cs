using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History();

            editor.Content = "test";
            history.Push(editor.CreateState());

            editor.Content = "test2";
            history.Push(editor.CreateState());

            editor.Content = "test3";
            editor.Restore(history.Pop());
            editor.Restore(history.Pop());
            Console.WriteLine(editor.Content);

        }
    }
}
