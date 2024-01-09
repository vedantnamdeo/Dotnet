using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Security.Cryptography;
namespace Emp;

internal class Employee
{
    private int id;
    private string? name;
    private int age;
    private double salary;

    private EmpType type;
    public static int count;

    public Employee(int id,string name,int age,double sal,EmpType type)
    {
        this.id=id;
        this.name=name;
        this.age=age;
        this.salary=sal;
        this.type=type;
        count++;

    }
    public Employee()
    {
        this.id=0;
        this.name="Yash";
        this.age=0;
        this.salary=0;
        this.type=EmpType.INTERN;
        count++;
    }
    public int Id{get;set;}
     public string? Name{get;set;}
    public int Age{get;set;}
    public double Salary{get;set;}
    public EmpType Type{get;set;}

    public static int Count{get{return count;}}
    public void finalize()
    {
        count--;
    }
    public Employee(int id)
    {
        this.id=id;
    }
    public override string ToString()
    {
        return "Id:"+id+",Name:"+name+",Age:"+age+",Salary:"+salary+",EmpType:"+type;
    }
}