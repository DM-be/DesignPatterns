using System;

namespace Memento_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new Document();
            var history = new History();

            document.FontName = "times new roman";
            document.FontSize = 8;
            document.Content = "test content";

            history.Push(document.CreateState());

            document.FontName = "arial";
            document.FontSize = 5;
            document.Content = "test content 2";

            history.Push(document.CreateState());

            document.FontName = "roboto";
            document.FontSize = 4;
            document.Content = "test content 3";
            
            document.Restore(history.Pop());



            Console.WriteLine(document.FontName);
        }
    }
}
