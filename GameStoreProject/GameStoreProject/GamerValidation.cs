using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
     class GamerValidation : IGamerValidation
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 2 &&
                gamer.DateOfBirth == "31.07.1995" &&
                gamer.FirstName == "Yagmur" &&
                gamer.LastName  == "Altug" &&
                gamer.NationalityId == "12345678912" 
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
