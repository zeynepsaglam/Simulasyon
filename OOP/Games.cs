using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisSitesiSimulasyonu
{
    class Games : IObject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Piece { get; set; }

    }
}
