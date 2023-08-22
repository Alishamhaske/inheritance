using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.inheritance
{
    /*Create class IPLTeam with method play. Create child classes of IPLTeam  called as CSK, RCB. 
  * In main, call play from child class objects*/
    public  class assignment5
        {
        static void Main(string[] args)
        {
            RCB r = new RCB();
            r.Play();
            r.play2();
            CSK c = new CSK();
            c.Play();
            c.play1();

        }
    }
    public class IPLTeam
    {
        public void Play()
        {
            Console.WriteLine("Play method implemented in IPLTeam class");
        }
    }
    public class CSK : IPLTeam
    {
        public void play1()
        {
            Console.WriteLine("class CSK");
        }
    }
    public class RCB : IPLTeam
    {
        public void play2()
        {
            Console.WriteLine("class RCB");
        }
    }

}
