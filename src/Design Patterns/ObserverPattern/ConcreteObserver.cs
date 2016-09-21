using System;

namespace Design_Patterns.ObserverPattern
{
    internal class ConcreteObserver : Observer
    {
        public ConcreteObserver(ConcreteSubject subject, string name) : base(subject,name){}

        public override void Update()
        {
            ObserverState = Subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}", Name, ObserverState);
        }
        
    }
}