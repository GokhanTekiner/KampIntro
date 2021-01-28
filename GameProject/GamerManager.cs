using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerManager
    {
        IUserValidateManager _userValidateManager;

        public GamerManager(IUserValidateManager userValidateManager)
        {
            _userValidateManager = userValidateManager;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidateManager.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt Başarılı");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız, Hatalı giriş");
            }
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi");
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidateManager.Validate(gamer) == true)
            {
                Console.WriteLine("Oyuncu silindi");
            }
            else
            {
                Console.WriteLine("İşlem Başarısız, oyuncu bulunamadı");
            }
        }
        
    }
}
