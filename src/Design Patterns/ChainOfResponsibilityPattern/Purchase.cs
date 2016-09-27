﻿namespace Design_Patterns.ChainOfResponsibilityPattern
{
    public class Purchase
    {
        // Constructor
        public Purchase(int number, double amount, string purpose)
        {
            Number = number;
            Amount = amount;
            Purpose = purpose;
        }

        // Gets or sets purchase number
        public int Number { get; set; }

        // Gets or sets purchase amount
        public double Amount { get; set; }

        // Gets or sets purchase purpose
        public string Purpose { get; set; }
    }
}