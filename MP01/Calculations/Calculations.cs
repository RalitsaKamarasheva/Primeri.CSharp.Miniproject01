using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class MainLibrary
    {
        //Дефиниции
        public Formula01 F01=new Formula01();
        public Formula02 F02=new Formula02();
        public Formula03 F03=new Formula03();

        //Библиотеки
        Colors.ForCLI cl=new Colors.ForCLI();
        public void Commands()
        {
            cl.Default();
            Console.WriteLine("Налични команди\n");
            cl.Command();
            Console.Write("[яма]");
            cl.Default();
            Console.WriteLine("- пресмятане на строителна яма");

            cl.Command();
            Console.Write("[въгъл]");
            cl.Default();
            Console.WriteLine("- пресмятане на вдлъбнат ъгъл");

            cl.Command();
            Console.Write("[иъгъл]");
            cl.Default();
            Console.WriteLine("- пресмятане на изпъкнал ъгъл\n");
        }
    }
}
