using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        public void CreateMarketingFirmWithManager()
        {
            Console.WriteLine("Please choose a stack or queue manager.");
            string input = Console.ReadLine();
            ISweepstakesManager manager = null;

            switch (input)
            {
                case "Stack":
                    Console.WriteLine("You Chose Stack Manager");
                    manager = new SweepstakesStackManager();
                    break;

                case "Queue":
                    Console.WriteLine("You Chose Queue Manager");
                    manager = new SweepstakesQueueManager();
                    break;

                default:
                    Console.WriteLine("Please Choose Stack or Queue");
                    break;

            }
            MarketingFirm marketingFirm = new MarketingFirm(manager);
        }
    }
}
