﻿using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class SelectionTool: ITool
    {
        public void MouseUp()
        {
            Console.WriteLine("Draw a dashed rectangle");
          
        }

        public void MouseDown()
        {
            Console.WriteLine("selection icon");
        }
    }
}
