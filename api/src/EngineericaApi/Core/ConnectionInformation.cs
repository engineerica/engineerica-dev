using System;

namespace EngineericaApi
{
	internal class ConnectionInformation
	{
		private static ConnectionInformation _accuClass;
		private static ConnectionInformation _ct;
		private static ConnectionInformation _accuWb;
		private static ConnectionInformation _accuCampus;
		private static ConnectionInformation _accuTraining;
		private static ConnectionInformation _accuClub;
		
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
			_accuCampus = new ConnectionInformation() { 
				Name ="AccuCampus", 
				ServiceUrl = "http://www.accucampus.net/" 
			};
			_accuTraining = new ConnectionInformation() { 
				Name ="AccuTraining", 
				ServiceUrl = "http://www.accutraining.net/" 
			};
			_accuClub = new ConnectionInformation() { 
				Name ="AccuClub", 
				ServiceUrl = "http://www.accuclub.net/" 
			};
		}
		private ConnectionInformation() {}
		
		public static ConnectionInformation AccuClass
		{
			get { return _accuClass; }
		}
		
		public static ConnectionInformation ConferenceTracker
		{
			get { return _ct; }
		}
		
		public static ConnectionInformation AccuWB
		{
			get { return _accuWb; }
		}
		
		public static ConnectionInformation AccuCampus
		{
			get { return _accuCampus; }
		}
		
		public static ConnectionInformation AccuTraining
		{
			get { return _accuTraining; }
		}
		
		public static ConnectionInformation AccuClub
		{
			get { return _accuClub; }
		}
		
		public string Name { get; set; }
		public string ServiceUrl { get; set; }
		
		public string LoginToken { get; set; }
		public bool IsLoggedIn {
			get {
				return LoginToken != null;
			}
		}
	}
}

