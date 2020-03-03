using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        

        static void AddFirstName(Contestant contestant)
        {            
            Console.WriteLine("Enter first name");
            contestant.firstName = Console.ReadLine();
        }

        static void AddLastName(Contestant contestant)
        {
            Console.WriteLine("Enter last name");
            contestant.lastName = Console.ReadLine();
        }
        static void AddEmail(Contestant contestant)
        {
            Console.WriteLine("Enter email");
            contestant.emailAddress = Console.ReadLine();
        }
        static void AddRegistration(Contestant contestant)
        {
            Console.WriteLine("Enter registration number");
            contestant.registrationNumber = int.Parse(Console.ReadLine());
        }        

    }
}
