using System;
using System.CodeDom;
using About;
using Calculations;
using Colors;

namespace UserInput
{
	public class UInput
	{
	    public About.Me about=new Me();
        public Colors.ForCLI cli=new ForCLI();
        public Calculations.MainLibrary calc=new MainLibrary();
		public UInput ()
		{
		}

	    public void sayHello()
	    {
	        cli.Default();
            Console.WriteLine("Добре дошли \n" + about.shortName + "\n"+about.version+"\n");

	    }

		public void getUserCommands()
		{
			string _command = "";
			do 
			{
				//Взимане на команди
				cli.Promt();    Console.Write("$ ");
				cli.Command();  _command=Console.ReadLine();

				//Проверка за налични команди
			    if (_command.ToLower().Contains("яма"))
			    {
                   calc.F01.calc(_command);
			    }
			    if (_command.ToLower().Contains("въгъл"))
			    {
			        calc.F02.calc(_command);
			    }
			    if (_command.ToLower().Contains("иъгъл"))
			    {
                    calc.F03.calc(_command);
			    }
                if (_command.ToLower().Contains("помощ") || _command.ToLower()=="п")
                {
                    calc.Commands();
                }
                if (_command.ToLower().Contains("изчисти") || _command.ToLower() == "и")
                {
                    Console.Clear();
                   sayHello();
                }

			} while(_command.ToLower() != "изход");

		}

		public void justTesting()
		{
			Console.WriteLine ("Стартиране на UserInput.UInput.justTesting()");

		}

	}
}

