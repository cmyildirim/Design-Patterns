using System;

namespace Design_Patterns.ObserverPattern.DotNetImplementation
{
    public struct Location
    {
        public Location(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public double Latitude { get; }

        public double Longitude { get; }
    }

    public class LocationUnknownException : Exception
    {
        internal LocationUnknownException()
        { }
    }
}