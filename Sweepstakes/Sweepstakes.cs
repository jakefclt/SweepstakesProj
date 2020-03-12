using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
   class Sweepstakes
    {

        Dictionary<int, Contestant> contestants;
        string name;
        int registrationCount = 1;
        //name property
        public string Name { get; }
        //Constructor
       public Sweepstakes(string name)
        {
            this.name = name;
        }
        //member method(Can Do)
         void RegisterContestant(Contestant contestant)
        {
           
            contestants.Add(registrationCount, contestant);
            registrationCount++;
        }
         Contestant PickWinner()
        {
            Contestant winner;
            int winningNumber;
            Random random = new Random();
            winningNumber= random.Next(1, registrationCount);
            winner = contestants[winningNumber];
            return winner;
            
        }
         void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.emailAddress);
            Console.WriteLine(contestant.registrationNumber);
        }
    }
}
