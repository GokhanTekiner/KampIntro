using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new SecondValidateManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "Gökhan",
                LastName = "Tekiner"
            });
            gamerManager.Delete(new Gamer
            {
                Id = 1,
                FirstName = "Gökhan",
                LastName = "Tekiner"
            });

        }
    }
}
