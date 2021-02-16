using System;
using System.Collections.Generic;
using System.Text;

namespace GameStoreProject
{
    class NewMemberValidationManager : IGamerValidation
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
