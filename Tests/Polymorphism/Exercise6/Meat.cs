﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    public class Meat : Food
    {
        public Meat(int quantity)
        : base(quantity)
        {
        }

        public override string ToString()
        {
            return "Meat";
        }
    }
}
