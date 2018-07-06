using System;

namespace Design_Patterns.ChainOfResponsibilityPattern
{
    public class VicePresident : Approver
    {
        internal override void ProcessRequest(Purchase purchase)
        {
            if (purchase.Amount < 25000.0)
                Console.WriteLine("{0} approved request# {1}",
                    GetType().Name, purchase.Number);
            else
                Successor?.ProcessRequest(purchase);
        }
    }
}