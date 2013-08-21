using System;

namespace EngineericaApi
{
	public class ConnectionInformation
	{
		private static ConnectionInformation _accuClass;
		private static ConnectionInformation _ct;
		private static ConnectionInformation _accuWb;
		
		static ConnectionInformation()
		{
			_accuClass = new ConnectionInformation() { 
				Name ="AccuClass", 
				ServiceUrl = "http://www.accuclass.net/" 
			};
			_ct = new ConnectionInformation() { 
				Name ="Conference-Tracker", 
				ServiceUrl = "http://www.conftrac.com/" 
			};
			_accuWb = new ConnectionInformation() { 
				Name ="AccuWB", 
				ServiceUrl = "http://www.accuwb.com/" 
			};
		}
		private ConnectionInformation() {}
		
		public string Name { get; set; }
		public string ServiceUrl { get; set; }
		
		public static ConnectionInformation AccuClass
		{
			get { return _accuClass; }
		}
		
		public static ConnectionInformation CT
		{
			get { return _ct; }
		}
		
		public static ConnectionInformation AccuWB
		{
			get { return _accuWb; }
		}
	}
}

