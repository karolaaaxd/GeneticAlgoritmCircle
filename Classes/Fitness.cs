using AForge.Genetic;
using System;
using System.Collections.Generic;

namespace Projekt2.Classes
{
    internal class Fitness : IFitnessFunction
    {
        private readonly List<Point> _points;

        public Fitness(List<Point> points)
        {
            _points = points;
        }

        public double Evaluate(IChromosome chromosom)
        {
            Chromosome circle = (Chromosome)chromosom;
            double totalDistance = 0;
            foreach (var point in _points)
            {
                double distance = Math.Sqrt(Math.Pow(point.X - circle.CenX, 2) + Math.Pow(point.Y - circle.CenY, 2));
                totalDistance += Math.Pow(distance - circle.Rad, 2);
            }
            return 1 / totalDistance;
        }
    }
}
