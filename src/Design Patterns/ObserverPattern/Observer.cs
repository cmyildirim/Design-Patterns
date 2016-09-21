namespace Design_Patterns.ObserverPattern
{
    public abstract class Observer
    {
        protected string Name { get; set; }
        protected string ObserverState { get; set; }
        protected ConcreteSubject Subject { get; set; }
        public abstract void Update();

        //Constructor
        protected Observer(ConcreteSubject subject, string name)
        {
            Subject = subject;
            Name = name;
        }
    }
}