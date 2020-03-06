using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm

    /*Dependency Injection used below to reduce class coupling and to increase code 
   reuasability as well as not having to change the class because of a dependency change.*/
    {
        ISweepstakesManager _manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
             _manager = manager;
        }
        void CreateSweepstakes()
        {
            Console.WriteLine("What would you like to name the Sweepstakes");
            Sweepstakes sweepstakes = new Sweepstakes(UserInterface.GetUserInput());

        }                  

    }
}
