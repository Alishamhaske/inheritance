using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static oopfirstclass_program.inheritance.person;

namespace oopfirstclass_program.inheritance
{
    public class personpro
    {
        static void Main(string[] args)
        {
           
            person p = new patient("Ab", 87687, 22, 656, "tanu", 768755443);
            Console.WriteLine(p.display());


            person p1 = new person(12, "alisha", 765728818);
            Console.WriteLine(p1.display());




        }
    }

    //base class person and child patient

    public class person
    {
        protected int id;
        protected string name;
        protected int adhar_num;

        public person(int id, string name, int adhar_num)
        {
            this.id = id;
            this.name = name;
            this.adhar_num = adhar_num;
        }
        public virtual string display()
        {
            return $"person id: {id} , person name : {name} Adhar num: {adhar_num} ";
        }

    }

        public class patient:person
        {
            private string blood_grp;
            private double bill;
            private int age;

            public patient(string blood_grp,double bill,int age, int id,string name,int adhar_num):base(id,name,adhar_num)
            {
                this.blood_grp = blood_grp;
                this.bill = bill;
                this.age = age;
            }

            public override string display()
            {
                return $"patient id:{id}  patient name:{name} age: {age}  patient adhar:{adhar_num} blood group : {blood_grp} bill : {bill}  ";
            }
        }
            
         
            

    
}
