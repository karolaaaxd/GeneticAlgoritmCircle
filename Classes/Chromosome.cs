using AForge.Genetic;
using System;

namespace Projekt2
{
    internal class Chromosome : ChromosomeBase
    {
        public double CenX { get; private set; }
        public double CenY { get; private set; }
        public double Rad { get; private set; }

        private Random _random = new Random();

        public Chromosome()
        {
            Rad = _random.NextDouble() * 0.707;
            CenX = _random.NextDouble();
            CenY = _random.NextDouble();
        }

        private Chromosome(Chromosome chromos)
        {
            Rad = chromos.Rad;
            fitness = chromos.Fitness;
            CenX = chromos.CenX;
            CenY = chromos.CenY;
        }

        public override IChromosome Clone()
        {
            return new Chromosome(this);
        }

        public override IChromosome CreateNew()
        {
            return new Chromosome();
        }

        public override void Crossover(IChromosome pair)
        {
            var other = (Chromosome)pair;
            double t = _random.NextDouble() * 2 * Math.PI;
            double cos = Math.Cos(t);
            double sin = Math.Sin(t);
            double rad = Rad;
            double centerX = CenX;
            double centerY = CenY;
            CenX = cos * centerX - sin * centerY + cos * other.CenX - sin * other.CenY;
            CenY = sin * centerX + cos * centerY + sin * other.CenX + cos * other.CenY;
            Rad = other.Rad;
            other.CenX = cos * other.CenX - sin * other.CenY + cos * centerX - sin * centerY;
            other.CenY = sin * other.CenX + cos * other.CenY + sin * centerY + cos * centerX;
            other.Rad = rad;
        }

        public override void Generate()
        {
            CenX = _random.NextDouble();
            CenY = _random.NextDouble();
            Rad = _random.NextDouble() * 0.707;
        }

        public override void Mutate()
        {
            switch (_random.Next(3))
            {
                case 0:
                    CenX = _random.NextDouble();
                    break;
                case 1:
                    CenY = _random.NextDouble();
                    break;
                case 2:
                    Rad = _random.NextDouble() * 0.707;
                    break;
            }
        }

        public override string ToString()
        {
            return $"X={CenX}, Y={CenY}, R={Rad}, Fitness={Fitness}";
        }
    }
}
