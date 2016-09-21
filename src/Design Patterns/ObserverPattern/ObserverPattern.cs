namespace Design_Patterns.ObserverPattern
{
    public class ObserverPattern : IPatternImplementation
    {
        public void Run()
        {
            ConcreteSubject subject = new ConcreteSubject();
            Observer observer1 = new ConcreteObserver(subject, "X");
            Observer observer2 = new ConcreteObserver(subject, "Y");
            Observer observer3 = new ConcreteObserver(subject, "Z");
            subject.RegisterObservers(observer1, observer2, observer3);
            
            // Change subject and notify observers
            subject.SubjectState = "ABC";
            subject.UnRegisterObservers(observer1, observer3);
            subject.SubjectState = "XYZ";
        }
    }
}