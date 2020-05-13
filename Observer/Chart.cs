using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Chart: IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine(value);
        }
    }
}
