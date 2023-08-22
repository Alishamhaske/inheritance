using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.inheritance
{
    public class assignment14Q
    {
        static void Main(string[] args)
        {

          
            actionclass a1 = new actionclass(2, 22, 23, "alisha", 77);
            a1.print();
            Console.WriteLine(a1.display());

            studentmangar s1 = new actionclass(6, 8, 22, "tanu", 78);
            Console.WriteLine(s1.display());


        }
    }

    /* Create Student class with the fields studentId, studentName, age, percentage.
  Create ManagerStudent class and two methods inside class –
 - createStudent
 - displayStudent*/

    public class student
    {
        protected int id;
        protected int age;
        protected string name;
        protected double persentage;

        public student(int id, int age, string name, double persentage)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.persentage = persentage;


        }
        public void print()
        {
            Console.WriteLine("create student:");
        }
    }
    //second class
    public class studentmangar:student
    { 
        public int stdmanager_id;
       

        public studentmangar( int stdmanager_id,int id, int age, string name, double persentage):base(id,age,name,persentage)
        {
           this.stdmanager_id = stdmanager_id;
            
        }

        public  virtual string display()
        {
            return $"studmanager_id: {stdmanager_id}, std_id: {id}, std_age,{age},name {name}, persentage:{persentage}";
        }
    }
        

    //third class
    public class actionclass:studentmangar
    {
        public actionclass(int stdmanagar_id, int id, int age, string name, double persentage) : base(stdmanagar_id,id, age, name, persentage)
        {


        }
        public override string display()
        {
            return $"studmanager_id: {stdmanager_id}, std_id: {id}, std_age,{age},name {name}, persentage:{persentage}";
        }

    }

            
    
        
}
