namespace Design_Patterns.ChainOfResponsibilityPattern
{
    public class ChainOfResponsibilityPattern : IPatternImplementation
    {
        public void Run()
        {
            Approver mrDirector = new Director();
            Approver mrVicePresident = new VicePresident();
            Approver mrPresident = new President();

            mrDirector.SetSuccessor(mrVicePresident);
            mrVicePresident.SetSuccessor(mrPresident);

            mrDirector.ProcessRequest(new Purchase(1, 350.00, "Assets"));
            mrDirector.ProcessRequest(new Purchase(2, 32590.10, "Project X"));
            mrDirector.ProcessRequest(new Purchase(3, 122100.00, "project Y"));

        }
    }
}