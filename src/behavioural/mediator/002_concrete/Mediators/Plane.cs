using System;

namespace Project
{
    public class Plane
    {
        public string Name { get; private set; }
        public FlightController Controller { get; private set; }

        private decimal _latitude;
        private decimal _longitude;

        public Plane(string name)
        {
            Name = name;
        }

        public void Register(FlightController controller)
        {
            Controller ??= controller;
        }

        public decimal ReceiveCoordinates(Plane sender, decimal latitude, decimal longitude)
        {
            // dab = sqrt(pow[(xb - xa),2] + pow[(yb - ya), 2]
            var distance =
                Math.Abs(
                    Math.Sqrt(
                        Math.Pow((double)latitude - (double)_latitude, 2) +
                        Math.Pow((double)longitude - (double)_longitude, 2)));

            return (decimal)distance;
        }

        public void StartFlightAt(decimal latitude, decimal longitude)
        {
            _latitude = latitude;
            _longitude = longitude;

            Console.WriteLine($"[{Name}] Starting flight at '{latitude},{longitude}'...");
        }

        public void SendCoordinates(decimal latitude, decimal longitude)
        {
            _latitude += latitude;
            _longitude += longitude;

            Console.WriteLine($"[{Name}] Reporting coordinates to '{Controller.Name}' as '{latitude},{longitude}'...");
            Controller.SendCoordinates(this, _latitude, _longitude);
        }
    }
}