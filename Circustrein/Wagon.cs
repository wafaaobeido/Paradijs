﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    class Wagon
    {
        public int Id { get; set; }
        public List<Dier> dieren = new List<Dier>();
        //public bool IsFull { get; set; }
    }
}
