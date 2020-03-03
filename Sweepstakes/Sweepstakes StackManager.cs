using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes_StackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack;
        public Sweepstakes_StackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);
        }
        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}
