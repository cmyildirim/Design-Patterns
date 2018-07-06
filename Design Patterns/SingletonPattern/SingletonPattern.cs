using System;

namespace Design_Patterns.SingletonPattern
{
    internal class SingletonPattern : IPatternImplementation
    {
        public void Run()
        {
            var b1 = LoadBalancer.GetLoadBalancer();
            var b2 = LoadBalancer.GetLoadBalancer();
            var b3 = LoadBalancer.GetLoadBalancer();
            var b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?
            if ((b1 == b2) && (b2 == b3) && (b3 == b4))
                Console.WriteLine("Same instance\n");

            // Load balance 15 server requests
            var balancer = LoadBalancer.GetLoadBalancer();
            for (var i = 0; i < 15; i++)
            {
                var server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            }
        }
    }
}