using System;
using System.Collections.Generic;

namespace Project
{
    public class FlightController
    {
        public string Name { get; private set; }
        public decimal SafeDistance { get; private set; }

        protected List<Plane> _planes;

        public FlightController(string name, decimal safeDistance)
        {
            Name = name;
            SafeDistance = safeDistance;
            _planes = new List<Plane>();
        }

        public void Register(Plane plane)
        {
            Console.WriteLine($"[{Name}] Registering plane '{plane.Name}'...");

            plane.Register(this);
            _planes.Add(plane);
        }

        public void SendCoordinates(Plane sender, decimal latitude, decimal longitude)
        {
            bool isRouteSafe = true;
            foreach(var receiver in _planes)
            {
                if (receiver.Equals(sender))
                    continue;

                var distanceFromSender = receiver.ReceiveCoordinates(sender, latitude, longitude);

                if (distanceFromSender <= SafeDistance)
                {
                    Console.WriteLine($"[{Name}] '{sender.Name}' at '{distanceFromSender}' distances from '{receiver.Name}'!");
                    isRouteSafe = false;
                }
            }

            Console.WriteLine($"[{Name}] '{sender.Name}', please {(isRouteSafe ? "proceed": "change")} route!");
        }
    }
}