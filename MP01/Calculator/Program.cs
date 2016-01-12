using System;

namespace Calculator
{
	class MainClass
	{
		//Дефиниране на библиотеки
		public UserInput.UInput uImput= new UserInput.UInput();
        public About.Me about=new About.Me();






		public static void Main (string[] args)
		{
		    MainClass program = new MainClass();

            //Форматиране на програмата
		    Console.Title = program.about.shortName + ", " + program.about.version;

			//Стартиране на програмата
            program.uImput.sayHello();
            program.uImput.getUserCommands ();
	
		}
	}
}
