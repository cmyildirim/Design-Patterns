﻿using System;

namespace Design_Patterns.DecoratorPattern
{
    public class DecoratorPattern : IPatternImplementation
    {
        public void Run()
        {
            // Create book
            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video
            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display
            Console.WriteLine("\nMaking video borrowable:");

            Borrowable borrowableVideo = new Borrowable(video);
            borrowableVideo.BorrowItem("Customer #1");
            borrowableVideo.BorrowItem("Customer #2");
            borrowableVideo.ReturnItem("Customer #1");

            borrowableVideo.Display();
        }
    }
}