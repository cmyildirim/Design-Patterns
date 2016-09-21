using System.Collections.Generic;

namespace Design_Patterns.ObserverPattern
{
    public abstract class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();
        public void RegisterObservers(params Observer[] observers)
        {
            foreach (var observer in observers)
            {
                _observers.Add(observer);
            }
        }

        public void UnRegisterObservers(params Observer[] observers)
        {
            foreach (var observer in observers)
            {
                _observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (Observer o in _observers)
            {
                o.Update();
            }
        }
    }
}