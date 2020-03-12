using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;


        public void GetUserInfo()
        {


            UserInterface.PromptFirstName();
            firstName = UserInterface.GetUserInput();

            UserInterface.PromptLastName();
            lastName = UserInterface.GetUserInput();

            UserInterface.PromptEmail();
            emailAddress = UserInterface.GetUserInput();

            UserInterface.PromptRegistration();
            bool validRespone = int.TryParse(UserInterface.GetUserInput(), out registrationNumber);

        }

    }

    
}
