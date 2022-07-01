﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Squeak : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
