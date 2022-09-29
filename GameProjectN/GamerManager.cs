using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectN
{
    internal class GamerManager : IGamerService
    {
        //MicroServis

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt Oldu.");
            }
            else
            {
                Console.WriteLine("Doğrualama başarısız.Kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi.");
        }
    }
}
