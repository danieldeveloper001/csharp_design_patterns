using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var controller = new FlightController("TAWA", safeDistance: 25);

            var plane1 = new Plane("KUROI");
            var plane2 = new Plane("SHIROI");
            var plane3 = new Plane("AKAI");

            controller.Register(plane1);
            controller.Register(plane2);
            controller.Register(plane3);

            plane1.StartFlightAt(10, 10);
            plane2.StartFlightAt(10, 50);
            plane3.StartFlightAt(10, 90);

            plane1.SendCoordinates(20, 20);
            plane2.SendCoordinates(20, 50);
            plane3.SendCoordinates(20, 80);

            plane1.SendCoordinates(30, 30);
            plane2.SendCoordinates(30, 50);
            plane3.SendCoordinates(30, 70);
        }
    }
}
