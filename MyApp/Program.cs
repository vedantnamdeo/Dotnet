// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

using MyApp;
using Show;

Person p= new Person(1,"Vedant",23);
Person p1 = new Person(2, "Shikhar", 22);
Person p2 = new Person { Id = 3, Name = "Aryan", Age = 24 };

Console.WriteLine(p.Count);   
Console.WriteLine(p+"\n"+p1+"\n");
Console.WriteLine(p2);

Console.WriteLine("----Employee--------");
Employee pp = new Employee(4,"Yash",24,6000,300,700);
float sal=pp.computePay();
Console.WriteLine(pp);
Console.WriteLine("Salary:"+sal);

Console.WriteLine("----Shape--------");
Point point = new Point(3, 5);
Point  point1=new Point(9, 3);

Line l=new Line("Black",4,"rectangle",point,point1);
Shape s = l;
s.Show();

Console.WriteLine("----Complex-------");
var c1 = new Complex(50, 30);
var c2 = new Complex(40, 20);
var c3 = c1 + c2;
Console.WriteLine(c3);