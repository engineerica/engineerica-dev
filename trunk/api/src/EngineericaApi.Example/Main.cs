using System;

namespace EngineericaApi.Example
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//var res = new EngineericaApi.AccuClass.User().List(0, 100);
			//res.
			
			var res = new EngineericaApi.AccuClass.Doc().Execute();
			Console.WriteLine (res.ResponseText);
			Console.ReadLine ();
		}
	}
}
