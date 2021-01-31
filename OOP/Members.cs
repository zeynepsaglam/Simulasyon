using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisSitesiSimulasyonu
{
    class Members : IObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string RTIdNumber { get; set; }
        public int Birthday { get; set; }
    }
}
