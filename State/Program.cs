using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.CurrentTool = new SelectionTool();
            canvas.MouseUp();
            canvas.MouseDown();
          
        }
    }
}
