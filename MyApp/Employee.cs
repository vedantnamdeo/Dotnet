using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Employee:Person
    {
        private float basicSalary;
        private float dailyallowance;
        private float deductions;


        public Employee() : base() 
        {
            this.basicSalary = 4000;
            this.dailyallowance = 400;
            this.deductions = 500;
        }
        public Employee(int id,string name,int age,float bs,float da,float ded) : base(id,name,age)
        {
            this.basicSalary = bs ;
            this.dailyallowance = da;
            this.deductions = ded;
        }

        public float BasicSalary { get { return this.basicSalary; } set { this.basicSalary = value; } }
        public float DailyAllowance { get { return this.dailyallowance; } set { this.dailyallowance = value; } }
        public float Deductions { get { return this.deductions;}set {  this.deductions = value; } }

        public  float computePay()
        {
            float totalSal=basicSalary+(dailyallowance*20)-deductions;
            return totalSal;
        }
        public override string ToString()
        {
            return base.ToString()+" basic Salary:"+ basicSalary+ " allowance:" + dailyallowance + " deductions:" + deductions+" TOTAL: "+computePay();
        }
    }
}
