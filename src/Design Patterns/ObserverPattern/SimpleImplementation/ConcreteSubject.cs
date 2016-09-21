using Design_Patterns.ObserverPattern.SimpleImplementation;

namespace Design_Patterns.ObserverPattern
{
    internal class ConcreteSubject : Subject
    {
        private string _subjectState;

        public string SubjectState
        {
            get { return _subjectState; }
            set
            {
                _subjectState = value;
                Notify();
            }
        }
    }
}