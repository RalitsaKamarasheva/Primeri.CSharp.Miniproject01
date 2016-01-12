using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    /// <summary>
    /// Клас за формула за обикновенна строителна яма. (Формула 1)
    /// </summary>
    public class Formula01
    {
        public Colors.ForCLI cl=new Colors.ForCLI();
        /// <summary>
        /// Метод за пресмятане на Формула 01
        /// </summary>
        /// <param name="userInput"></param>
       
        public void calc(string userInput)
        {
            try
            {
                string[] param = userInput.Split(' ');
                if (param.Length>1 && userInput.Contains("-п"))
                {
                    //Помощ за командата
                    Help();

                }
                if (param.Length > 1 && !userInput.Contains("-п"))
                {
                    //Изчисления
                    double result = 0;
                    if (runCalculations(param, out result))
                    {
                        Console.Write("Обема на строителната яма е: ");
                        Console.WriteLine(result.ToString("N2"));
                    }
                    else
                    {
                        Console.WriteLine("Има грешно въведени параметри. Можете да проверите синтаксиса с параметъра '-п'"); 
                    }

                }
            }
            catch
            {
                
            }
            
        }
        /// <summary>
        /// Вътрешен метод за пресмятане на формула1, след парсване на командата от потребителя.
        /// </summary>
        /// <param name="param">Това е масив от стрингове, който съдържа командата с параметри от потребителя.</param>
        /// <param name="result">В тази променлива ще се върне резулата от формулата.</param>
        /// <returns>методът връща true при успешно изпълнение.</returns>
        private bool runCalculations(string[] param, out double result)
        {
            try
            {
                double a1 = 0, b1 = 0, a2 = 0, b2 = 0, h = 0;
                //param[0] == <име на команда>
                Double.TryParse(param[1], out a1);
                Double.TryParse(param[2], out b1);
                Double.TryParse(param[3], out a2);
                Double.TryParse(param[4], out b2);
                Double.TryParse(param[5], out h);

                double F1 = a1*b1, F2 = a2*b2;
                result = h*(F1 + F2)/2;
                return true;
            }
            catch
            {
                // ignored
            }
            result = 0;
            return false;
        }
        /// <summary>
        /// Вътрешен метод, който показва синтаксиса на командата в командния ред.
        /// </summary>
        private void Help()
        {
            cl.Result(); Console.Write("[яма]");
            cl.Default(); Console.WriteLine("-команда за пресмятане на строителна яма");

            cl.Command(); Console.Write("параметри ");
            cl.Default(); Console.WriteLine("a1,b1,a2,b2 и h");

            cl.Command(); Console.Write("a1 и b1");
            cl.Default(); Console.WriteLine("-ширина и дължина на горната страна на изкопа");

            cl.Command(); Console.Write("a2 и b2");
            cl.Default(); Console.WriteLine("-ширина и дължина на долната страна на изкопа");

            cl.Command(); Console.Write("h");
            cl.Default(); Console.WriteLine("-височина\n");

        }


    }
}
