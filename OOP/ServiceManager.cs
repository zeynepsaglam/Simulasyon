using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisSitesiSimulasyonu
{
    class ServiceManager : IService
    {
        public void Add(IObject obj)
        {
            Console.WriteLine(obj.Name + " eklendi.");
        }

        public void Delete(IObject obj)
        {
            Console.WriteLine(obj.Name + " silindi.");
        }

        public void Update(IObject obj)
        {
            Console.WriteLine(obj.Name + " güncellendi.");
        }
    }
}
