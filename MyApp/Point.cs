﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show
{
    internal struct Point
    {
        private int x; private int y;

        public int X { get; set; }
            public int Y { get; set; }

        public Point(int x, int y)
        {
            this.x=x;
                this.y=y;
        }
        public override string ToString() {
            return "{X=" + x + ",Y=" + y + "}";
        }
    }
}
