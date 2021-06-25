using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Computer :IEntities
    {
        public string ComputerName { get; set; }
        public int ComputerId { get; set; }
        public short ComputerPrice { get; set; }
        public string ComputerBrand { get; set; }
    }
}
