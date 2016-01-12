using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class Formula02
    {
        Colors.ForCLI cl=new Colors.ForCLI();
        //Формула за вдлъбнат ъгъл
        public void calc(string userInput)
        {
            try
            {
                string[] param = userInput.Split(' ');
                if (param.Length > 1 && userInput.ToLower().Contains("-п"))
                {
                    //Помощ за командата
                    Help();

                }
                if (param.Length ==4)
                {
                    //Изчисления
                    double result = 0;
                    if (runCalculations(param, out result))
                    {
                       cl.Default(); Console.Write("Обема на вдлъбнатия ъгъл е: ");
                       cl.Result(); Console.Write(result.ToString("N2"));
                       cl.Default(); Console.WriteLine("м3\n");
                    }
                    else
                    {
                       cl.Default(); Console.WriteLine("Има грешно въведени параметри. Можете да проверите синтаксиса с параметъра '-п'");
                    }

                }
            }
            catch
            {

            }

        }

        private bool runCalculations(string[] param, out double result)
        {
            try
            {
                double a = 0, b = 0, h = 0;
                //param[0] == <име на команда>
                Double.TryParse(param[1], out a);
                Double.TryParse(param[2], out b);
                Double.TryParse(param[3], out h);
                result = (a*b*h) / 3;
                return true;
            }
            catch
            {
                // ignored
            }
            result = 0;
            return false;
        }
        private void Help()
        {
            cl.Result();    Console.Write("[въгъл]");
            cl.Default();   Console.WriteLine("-вдлъбнат ъгъл");

            cl.Command();   Console.Write("параметри ");
            cl.Default();   Console.WriteLine("a,b и h");

            cl.Command();   Console.Write("a и b");
            cl.Default();   Console.WriteLine("-ширина и дължина");

            cl.Command();   Console.Write("h");
            cl.Default();   Console.WriteLine("-височина\n");

        }
    }

  
}
