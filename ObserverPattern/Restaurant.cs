using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Restaurant : ISubject
    {
        public List<IObserver> observers = new List<IObserver>();

        public string Name { get; set; }
        public string Menus { get; set; }
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in this.observers)
            {
                observer.Update(Menus);
            }
        }
    }
}
