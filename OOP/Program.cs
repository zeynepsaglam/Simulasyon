using System;

namespace OyunSatisSitesiSimulasyonu
{
    class Program
    {
        static void Main(string[] args)
        {
            Members member1 = new Members { Id = 1, Name = "Zeynep", Surname = "Sağlam", RTIdNumber = "12345678910", Birthday = 1999 };
            Members member2 = new Members { Id = 1, Name = "Sevde", Surname = "Özdemir", RTIdNumber = "32543442341", Birthday = 1997 };
            Discounts discount1 = new Discounts { Id = 1, Name = "sepette %15", Discount = 15 };
            Games game1 = new Games { Id = 1, Name = " GTA V", };

            ServiceManager serviceManager = new ServiceManager();
            serviceManager.Add(member1);
            serviceManager.Delete(member2); ;
            serviceManager.Update(discount1);

            MembersValidate validate = new MembersValidate();
            validate.Check(member1);

            SalesManager salesManager = new SalesManager();
            salesManager.Sale(member2, game1, discount1);

        }
    }
}
