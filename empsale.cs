using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static oopfirstclass_program.inheritance.employee1;

namespace oopfirstclass_program.inheritance
{
    public class empsale
    {
        static void Main(string[] args)
        {
            employee1 e1 = new saleemployee(2000,1000,5,"tanu",80000);
            e1.calculatesalary();
            Console.WriteLine(e1.display());

            employee1 e2 = new employee1(2, "alisha", 76665);
            e2.calculatesalary();
            Console.WriteLine(e2.display());

        }
    }
    /*From the existing Employee class create new child class called SalesEmployee& 
        implement the inheritance(bonus+comm) & polymorphism(method overriding)*/

    public class employee1
    {
        protected int id;
        protected string name;
        protected double emp_salary;

        public employee1(int id, string name, double emp_salary)
        {
            this.id = id;
            this.name = name;
            this.emp_salary = emp_salary;
        }
        public virtual string calculatesalary()
        {
            return $"employee salary: {emp_salary}";

        }

        public virtual string display()
        {
            return $"employee id: {id},employee name: {name} ,employee salary{emp_salary}";
        }
    }
    public class saleemployee:employee1
    {
            private int bonus;
            private int comm;
            private double saleemployee_salary;

            public saleemployee(int bonus, int comm, int id, string name, double emp_salary):base(id,name,emp_salary)
            {
                this.bonus = bonus;
                this.comm = comm;
            }

            public override string calculatesalary()
            {
                saleemployee_salary = emp_salary + bonus + comm;
                return$"sale employee salary is:  {saleemployee_salary}";
            }

            public override string display()
            {
                return $"sale employee id: {id},sale employee name: {name} ,sale employee salary{saleemployee_salary}";
            }
    }
            



    
}
