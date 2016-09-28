using System;
using System.Collections.Generic;

namespace Design_Patterns.SingletonPattern
{
    public class LoadBalancer
    {
        private readonly List<string> _servers = new List<string>();
        private static volatile LoadBalancer _instance;

        // Lock synchronization object
        private static readonly object SyncLock = new object();
        private readonly Random _random = new Random();

        private LoadBalancer()
        {
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        // Support multithreaded applications through
        // 'Double checked locking' pattern which (once
        // the instance exists) avoids locking each
        // time the method is invoked
        public static LoadBalancer GetLoadBalancer()
        {
            if (_instance != null) return _instance;
            lock (SyncLock)
            {
                if (_instance == null)
                {
                    _instance = new LoadBalancer();
                }
            }
            return _instance;
        }

        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}