namespace Design_Patterns.ChainOfResponsibilityPattern
{
    public abstract class Approver
    {
        protected Approver Successor;

        internal void SetSuccessor(Approver successor)
        {
            Successor = successor;
        }

        internal abstract void ProcessRequest(Purchase purchase);
    }
}