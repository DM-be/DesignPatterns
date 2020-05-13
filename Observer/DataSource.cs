using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class DataSource
    {

        private List<IObserver> Observers { get; set; } = new List<IObserver>();

        private int _Value;

        public int Value
        {
            get => _Value;
            set
            {
                _Value = value;
                NotifyObservers();

            }
        }

        public void NotifyObservers()
        {
            foreach (var observer in Observers)
            {  
                observer.Update(Value);
            }
        }

        public void AddObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            
        }
    }

}