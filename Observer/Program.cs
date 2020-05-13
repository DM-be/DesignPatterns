using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataSource = new DataSource
            {
                Value = 5
            };
            dataSource.AddObserver(new Chart());
            dataSource.Value = 6;
            dataSource.Value = 7;
        }
    }
}
