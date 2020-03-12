using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        

        public static void PromptFirstName()
        {            
            Console.WriteLine("Enter first name");
            
        }

        public static void PromptLastName()
        {
            Console.WriteLine("Enter last name");
            
        }
        public static void PromptEmail()
        {
            Console.WriteLine("Enter email");
            
        }
        public static void PromptRegistration()
        {
            Console.WriteLine("Enter registration number");
            
        }
        public static string GetUserInput()
        {
          
            string userInput;
            userInput = Console.ReadLine();
            return userInput;

        }

    }
}
