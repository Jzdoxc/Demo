﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市收银系统
{
    class Samsung : ProductFather
    {
        public Samsung(string name, double price, int count, string id) : base(name, price, count, id)
        {
            this.Name = name;
            this.Price = price;
            this.Count = count;
            this.ID = id;
        }
    }
}
