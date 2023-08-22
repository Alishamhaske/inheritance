using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.inheritance
{
    public class multilevel
    {
        static void Main(string[] args)
        {
            son s1 = new son("prasad", 25, "sanjay", 45, "machhindra", 78);
            Console.WriteLine(s1.display1());
            Console.WriteLine(s1.display2());
            Console.WriteLine(s1.display3());








        }
    }

    //multilevel inheritance
    public class grandfather
    {
        public string g_name;
        public int g_age;

        public grandfather(string g_name, int g_age)
        {
            this.g_name = g_name;
            this.g_age = g_age;
        }
        public  string display1()
        {
            Console.WriteLine("grand father details");
            return $"grandfather_name:{g_name} grand_age:{g_age}";
        }  

    }
    //father class
    public class father:grandfather
    {
        public string f_name;
        public int f_age;
        public father(string f_name,int f_age,string g_name,int g_age):base(g_name,g_age)
        {
            this.f_name = f_name;
            this.f_age = f_age;

        }

        public  string display2()
        {
            Console.WriteLine("father deatils:");
            return $"grandfather_name:{g_name} grand_age:{g_age}" +
                $"father_name:{f_name} father_age:{f_age}";
        }


    }
    //son class
    public class son : father
    {
        public string s_name;
        public int s_age;
        public son(string s_name,int s_age,string f_name, int f_age, string g_name, int g_age) : base(f_name,f_age,g_name, g_age)
        {
            this.s_name = s_name;
            this.s_age = s_age;

        }

        public  string display3()
        {
            Console.WriteLine("son details");
            return $"{s_name} {f_name} {g_name}  Mhaske ," +
                $"grand_age:{g_age} father_age:{f_age} son age: {s_age} ";
                 
        }


    }





}
