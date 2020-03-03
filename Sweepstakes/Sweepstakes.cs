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
        public string Name { get; }
   
        public Sweepstakes(string name)
        {
            this.name = name;
        }
        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestant.registrationNumber, contestant);
        }
        public Contestant PickWinner()
        {
            Random random = new Random();
            random.Next();
            //return a random number from dictionary
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName);
            Console.WriteLine(contestant.lastName);
            Console.WriteLine(contestant.emailAddress);
            Console.WriteLine(contestant.registrationNumber);
        }
    }
}
