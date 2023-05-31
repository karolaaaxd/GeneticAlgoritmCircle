using AForge.Genetic;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2.Classes
{
    internal class GA
    {
        public async Task<Chromosome> Calc(List<Point> points, int Size, int max, float mutation, float crossover, int Method, PointAndCircleDrawer drawer, TextBox iterations, TextBox best1, TextBox bestX, TextBox bestY, TextBox Diameter1)
        {
            var floatPoints = points.Select(p => new PointF((float)p.X, (float)p.Y)).ToList();
            var population = new Population(Size, new Chromosome(), new Fitness(points), GetSelection(Method));
            population.CrossoverRate = crossover;
            population.MutationRate = mutation;
            population.RunEpoch();
            Chromosome best = (Chromosome)population.BestChromosome;
            double bestFitness = best.Fitness;
            for (int i = 1; i < max; i++)
            {
                iterations.Text = (i + 1).ToString();
                population.RunEpoch();
                Chromosome bestchrom = (Chromosome)population.BestChromosome;
                if (bestchrom.Fitness > bestFitness)
                {
                    best = bestchrom;
                    bestFitness = bestchrom.Fitness;
                    best1.Text = "Radius: " + bestchrom.Rad.ToString();
                    drawer.Draw(floatPoints, new PointF((float)bestchrom.CenX, (float)bestchrom.CenY), bestchrom.Rad, Color.White);
                    bestX.Text = "X: " + bestchrom.CenX.ToString();
                    bestY.Text = "Y: " + bestchrom.CenY.ToString();
                    Diameter1.Text = "Diameter: " + (2 * bestchrom.Rad).ToString();
                }
                await Task.Delay(1);
            }
            return best;
        }

        private ISelectionMethod GetSelection(int Method)
        {
            switch (Method)
            {
                case 0:
                    return new EliteSelection();
                case 1:
                    return new RouletteWheelSelection();
                case 2:
                    return new RankSelection();
                default:
                    return new EliteSelection();
            }
        }
    }
}
