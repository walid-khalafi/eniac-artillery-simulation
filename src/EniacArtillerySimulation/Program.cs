namespace EniacArtillerySimulation
{
    class ArtilleryFiringTable
    {
        static void Main()
        {
            double g = 9.81;   // Gravity (m/s^2)
            double dt = 0.01;  // Time step (seconds)

            var powders = new (string Name, double Velocity)[]
            {
            ("Charge 3", 300),
            ("Charge 5", 450),
            ("Charge 7", 562)
            };

            var weather = new (string Name, double DensityFactor)[]
            {
            ("Cold & Dry", 1.05),
            ("Standard", 1.00),
            ("Warm & Humid", 0.95)
            };

            double Cd = 0.295;   // Drag coefficient
            double A = 0.0189;   // Cross-sectional area (m²)
            double m = 43.0;     // Mass (kg)

            Console.WriteLine("Charge\t\tWeather\t\tAngle\tRange (m)\tFlight Time (s)");

            foreach (var p in powders)
            {
                foreach (var w in weather)
                {
                    for (int angleDeg = 30; angleDeg <= 60; angleDeg += 5)
                    {
                        double angleRad = angleDeg * Math.PI / 180.0;
                        double vx = p.Velocity * Math.Cos(angleRad);
                        double vy = p.Velocity * Math.Sin(angleRad);

                        double x = 0, y = 0, t = 0;

                        while (y >= 0)
                        {
                            double v = Math.Sqrt(vx * vx + vy * vy);
                            double drag = 0.5 * w.DensityFactor * v * v * Cd * A;
                            double ax = -(drag / m) * (vx / v);
                            double ay = -(drag / m) * (vy / v) - g;

                            vx += ax * dt;
                            vy += ay * dt;

                            x += vx * dt;
                            y += vy * dt;
                            t += dt;
                        }

                        Console.WriteLine($"{p.Name}\t{w.Name}\t{angleDeg}\t{x:F1}\t\t{t:F2}");
                    }
                }
            }
        }
    }

}

