using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SecondValidateManager : IUserValidateManager
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id == 1 && gamer.FirstName == "Gökhan" && gamer.LastName == "Tekiner")
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
