using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisSitesiSimulasyonu
{
    class MembersValidate
    {
        public void Check(Members member)
        {
            Members dbMember1 = new Members { Id = 1, Name = "Zeynep", Surname = "Sağlam", RTIdNumber = "12345678910", Birthday = 1999 };

            if (member.Id == dbMember1.Id)
            {
                Console.WriteLine("Kullanıcı doğrulaması yapıldı");
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulaması yapılamadı");
            }
        }
    }
}
