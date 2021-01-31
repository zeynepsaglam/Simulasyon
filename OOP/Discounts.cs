using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisSitesiSimulasyonu
{
    class Discounts : IObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Discount { get; set; }
    }
}
