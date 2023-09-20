using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oopfirstclass_program.inheritance
{
    public class emp1
    {
        static void Main(string[] args)
        {
           

            employee e1 = new managar(2000, 4, 50000);
            e1.grosssalary();
            Console.WriteLine(e1.display());

            employee e2 = new employee(12, 6000);
            e2.grosssalary();
            Console.WriteLine(e2.display());


        }
    }


    //base class is employee and child/derived class is managar
    public class employee
    {
        protected int emp_id;
        protected double emp_salary;
        protected double hra, da, pf, ta;
        
        protected double gross;

        public employee(int emp_id,double emp_salary)
        {
            this.emp_id = emp_id;
            this.emp_salary = emp_salary;
        }

        public virtual void grosssalary()
        {

            hra = emp_salary * 0.40;
            da = emp_salary * 0.20;
            ta = emp_salary * 0.10;
            pf = emp_salary * 0.12;
             gross = (emp_salary + hra + da + ta) - pf;
            


        }
        public virtual string display()
        {
            return $"emp_id:{emp_id} emp_salary:{emp_salary} employee gross salary :{gross}";
        }
    }


    //child class=managar
    public class managar:employee
    {
        private double foodallowance;
        
        


        public managar(double foodallowance,int emp_id,double emp_salary):base(emp_id,emp_salary)
        {
            this.foodallowance = foodallowance;
        }
        public override void grosssalary()
        {

            hra = emp_salary * 0.40;
             da = emp_salary * 0.20;
             ta = emp_salary * 0.10;
             pf = emp_salary * 0.12;
             gross = (emp_salary + hra + da + ta+foodallowance) - pf;
            
        }
        public override string display()
        {
            return $"manager_id:{emp_id} manager_salary:{emp_salary} manager gross salary :{gross}";
        }

    }
}
