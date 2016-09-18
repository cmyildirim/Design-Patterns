﻿using System;
using System.Collections.Generic;

namespace Design_Patterns.DecoratorPattern
{
    /// <summary>
    /// The 'ConcreteDecorator' class
    /// </summary>
    class Borrowable : Decorator
    {
        protected List<string> Borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            Borrowers.Add(name);
            LibraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            Borrowers.Remove(name);
            LibraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in Borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }
}