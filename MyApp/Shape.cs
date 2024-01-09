using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show
{
    internal abstract class Shape
    {
        private string color;
        private int thickness;
        private string style;

        public Shape()
        {
            this.color = "blue";
            this.thickness = 1;
            this.style = string.Empty;

        }
        public Shape(string col, int thick,string sty)
        {
            this.color= col;
                this.thickness = thick;
                this.style = sty;
        }
        public abstract void Show();

        public override string ToString()
        {
            return "color: "+this.color+", thickness:"+this.thickness+", Style:"+this.style;
        }
    }
}
