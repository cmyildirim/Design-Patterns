namespace Design_Patterns.ObserverPattern
{
    public class ConcreteSubject : Subject
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