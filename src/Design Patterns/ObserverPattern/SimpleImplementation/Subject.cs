using System.Collections.Generic;

namespace Design_Patterns.ObserverPattern.SimpleImplementation
{
    public abstract class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();
        internal void RegisterObservers(params Observer[] observers)
        {
            foreach (var observer in observers)
            {
                if (!_observers.Contains(observer))
                    _observers.Add(observer);
            }
        }

        internal void UnRegisterObservers(params Observer[] observers)
        {
            foreach (var observer in observers)
            {
                _observers.Remove(observer);
            }
        }

        public void Notify()
        {
            foreach (var o in _observers)
            {
                o.Update();
            }
        }
    }
}