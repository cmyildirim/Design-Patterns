using System;

namespace Design_Patterns.ChainOfResponsibilityPattern
{
    public class President : Approver
    {
        internal override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 100000.0)
                Console.WriteLine("{0} approved request# {1}",
                    GetType().Name, purchase.Number);
            else
                Console.WriteLine(
                    "Request# {0} requires an executive meeting!",
                    purchase.Number);
        }
    }
}