using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Show
{
    internal class Line:Shape
    {
        Point start;
        Point end;
        public Line(string col,int thick,string sty,Point start, Point end):base(col,thick,sty)
        {
            this.start = start; 
                this.end = end;
        }
        public override void Show()
        {
            Console.WriteLine("Start: "+start+", End:"+end+" "+base.ToString());
        }
    }
}
