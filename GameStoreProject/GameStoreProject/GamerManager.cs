using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    class GamerManager : IGamerManager
    {
        IGamerValidation _gamerValidation;

        public GamerManager(IGamerValidation gamerValidation)
        {
            _gamerValidation = gamerValidation;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerValidation.Validate(gamer) == true)
            {
                Console.WriteLine("Your registration has been successfully completed");
            }
            else
            {
                Console.WriteLine("Sorry, Your registration could not be processed. Please check your information and try again.");
            }

        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Your registration has been successfully updated");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Your registration has been successfully deleted");
        }
    }
}
