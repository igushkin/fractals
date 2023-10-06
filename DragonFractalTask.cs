using System;
using System.Drawing;

namespace Fractals
{
    internal static class DragonFractalTask
    {
        public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
        {
            var random = new Random(seed);
            double angle45 = 45 * Math.PI / 180;
            double angle135 = 135 * Math.PI / 180;
            double x = 1;
            double y = 0;
            iterationsDrowing(pixels, angle45, angle135, random, x, y, iterationsCount);
        }
        public static void iterationsDrowing(Pixels pixels, double angle45, double angle135, Random random, double x, double y, int iterationsCount)
        {
            for (int i = 0; i < iterationsCount; i++)
            {
                var nextNumber = random.Next(10);
                double x1, y1;
                if (nextNumber < 5)
                {
                    x1 = (x * Math.Cos(angle45) - y * Math.Sin(angle45)) / Math.Sqrt(2);
                    y1 = (x * Math.Sin(angle45) + y * Math.Cos(angle45)) / Math.Sqrt(2);
                }
                else
                {
                    x1 = (x * Math.Cos(angle135) - y * Math.Sin(angle135)) / Math.Sqrt(2) + 1;
                    y1 = (x * Math.Sin(angle135) + y * Math.Cos(angle135)) / Math.Sqrt(2);
                }
                x = x1;
                y = y1;
                pixels.SetPixel(x, y);
            }
        }
    }
}