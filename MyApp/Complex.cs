using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Complex
    {
        private int real;
        private int imaginary;
        public int Real { get { return this.real; } set {  this.real = value; } }
        public int Imaginary { get { return this.imaginary; } set { this.imaginary = value; } }
        public Complex() { this.real = 0;this.imaginary = 0; }

           public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static Complex operator +(Complex left, Complex right) {
            Complex t = new Complex();
            t.real=left.real + right.real;
            t.imaginary=left.imaginary + right.imaginary;
            return t;


        }
        public override string ToString()
        {
            return real+"+"+imaginary+"i";
        }
    }
}
