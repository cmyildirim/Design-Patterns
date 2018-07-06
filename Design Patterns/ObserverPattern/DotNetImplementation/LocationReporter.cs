using System;

namespace Design_Patterns.ObserverPattern.DotNetImplementation
{
    internal class LocationReporter : IObserver<Location>
    {
        private IDisposable Subscriber { get; set; }
        private string InstName { get; }

        public LocationReporter(string name)
        {
            InstName = name;
        }

        public string Name => InstName;

        public virtual void Subscribe(IObservable<Location> provider)
        {
            if (provider != null)
                Subscriber = provider.Subscribe(this);
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine("The Location Tracker has completed transmitting data to {0}.", Name);
            Unsubscribe();
        }

        public virtual void OnError(Exception e)
        {
            Console.WriteLine("{0}: The location cannot be determined.", Name);
        }

        public virtual void OnNext(Location value)
        {
            Console.WriteLine("{2}: The current location is {0}, {1}", value.Latitude, value.Longitude, Name);
        }

        public virtual void Unsubscribe()
        {
            Subscriber.Dispose();
        }
    }
}