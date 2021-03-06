﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaraunt.CondimentDecorators
{
    public class IceCreamDecorator : Decorator
    {
        public IceCreamDecorator(Product product) : base(product)
        {
        }

        public override string Name => base.Name + ", With ice cream";

        public override decimal Price => base.Price + 0.30m;
    }
}
