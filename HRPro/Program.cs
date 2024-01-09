// See https://aka.ms/new-console-template for more information
using Emp;
using System;
using System.Collections.Generic;

        List<Employee> list=new List<Employee>();
        list.Add(new Employee(1,"Vedant",23,50000,EmpType.FULLTIME));
         list.Add(new Employee(2,"Shikhar",22,40000,EmpType.HALFTIME));
          list.Add(new Employee(3,"Aryan",24,70000,EmpType.INTERN));
        Boolean exit=false;

        while(!exit)
        {
            Console.WriteLine("1.Add\n2.Display\n3.Total Employees\n4.Find By ID");
            Console.WriteLine("Enter choice:");
                 switch(Convert.ToInt32(Console.ReadLine()))
                 {
                    case 1: Console.WriteLine("Enter id,name,age,salary,type");
                                list.Add(new Employee(5,"PBhure",25,40000,EmpType.FULLTIME));
                                Employee em=new Employee(Convert.ToInt32(Console.ReadLine()),Console.ReadLine(),Convert.ToInt32(Console.ReadLine()),Convert.ToDouble(Console.ReadLine()));
                            break;
                    case 2:foreach(Employee e in list)
                            {
                                Console.WriteLine(e);
                            }
                            break;
                    case 3:Console.WriteLine(list.Count);
                            break;
                    case 4:Console.WriteLine("Enter id:");
                                int id=Convert.ToInt32(Console.ReadLine());
                                Employee emp=new Employee(id);
                                foreach(Employee e1 in list)
                                {
                                        if(list.Contains(emp)) //if(e1.Id==id)
                                        {
                                                Console.WriteLine(e1);
                                        }
                                        //Console.WriteLine("hello");
                                }
                            break;
                    
                    default:
                            break;

                 }
        }
       

 