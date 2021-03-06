﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class PestoDecorator : Decorator
    {
        public PestoDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With pesto";

        public override decimal Price => base.Price + 0.25m;
    }
}
