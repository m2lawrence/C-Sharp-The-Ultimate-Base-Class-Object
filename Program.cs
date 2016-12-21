//Page 370, day 10: Everything is an Object in C#.
//Michael Lawrence BSc (HONS) 
using System;

namespace EverythingIsAnObject
{
	//"sealed" means cannot derive/inherit this class from the base class myApp.
	sealed class PI
	{
		//visible to all, class high level variable, big data type, name nbr.
		public static float nbr; //declares the variable. 
		
		//static means: class high level, PI method.
		static PI()
		{
			nbr = 3.14159F; //assign number to nbr variable.
		}
		
		//static: class high level, public: visible to all classes and objects, float big data type, value method.
		static public float val()
		{
			return(nbr); //assign static PI nbr variable, inside a return method, inside the value method.
		}
	}
	
	class myApp
	{
		//computer starts running from the "Main" method here.
		//public everyone/objects can see it, static class high level variable, void: returns null/empty method, starts running here at the "Main" method. 
		public static void Main()
		{
			Console.WriteLine("Mike, PI = {0}", PI.val()); //Writes out PI.
			
			//C# "Object" is the Ultimate Base Class. It has this object and the PI method joined onto it, so this whole C# programme is actually the base class "Object" used.
			//Ultimate Base Class, new object named x, =new class method: builds the object x.
			Object x = new PI();
			
			//convert object int x to string data type.
			Console.WriteLine("ToString: {0}", x.ToString());
			//tells you the data type.
			Console.WriteLine("Type: {0}", x.GetType());
			//------------------------------------------------
			//changes integer to string data type. 
			Console.WriteLine("ToString: {0}", 123.ToString());
			//returns the type Int32. 
			Console.WriteLine("Type: {0}", 123.GetType()); 
			
			Console.ReadKey(true); //pause to read.
		}
	}
}