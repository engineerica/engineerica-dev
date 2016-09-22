using System;
using EngineericaApi.ExtensionFiles.AccuClass;

namespace EngineericaApi.Example
{
	class MainClass
	{
		private static string domain;
		private static string email;
		private static string password;
		
		#region Console helper methods
		
		public static void Main (string[] args)
		{
			// Select Example
			var example = ShowExampleSelection();
			
			// Ask for the credentials
			AskForCredentials();
			
			// Run example
			switch (example)
			{
				case "1":
					Console.Clear();
					RunAccuClassExample();
					break;
				case "2":
					Console.Clear();
					RunCTExample();
					break;
				case "3":
					Console.Clear();
					RunAccuWBExample();
					break;
				case "4":
					Console.Clear();
					RunAccuClassExportExample();
					break;
				case "5":
					Console.Clear();
					ViewAccuClassAttendanceExample();
					break;
				default:
					Console.Clear();
					Console.WriteLine ("Example not valid.");
					break;
			}
			Console.WriteLine ("");
			Console.WriteLine ("");
			Console.WriteLine ("Press any key to exit.");
			Console.ReadLine ();
		}
		
		public static string ShowExampleSelection()
		{
			Console.WriteLine ("Select the example you want to run:");
			Console.WriteLine ("1. AccuClass: basic list classrooms");
			Console.WriteLine ("2. Conference-Tracker: basic list rooms");
			Console.WriteLine ("3. AccuWB: basic list rooms");
			Console.WriteLine ("4. AccuClass: export students");
			Console.WriteLine ("5. AccuClass: view student attendance");
			Console.WriteLine ("");
			Console.Write ("Type the example number and press enter: ");
			
			return Console.ReadLine ();
		}
		
		public static void AskForCredentials()
		{
			Console.Clear();
			Console.WriteLine("Enter the login credentials to run this example.");
			Console.WriteLine ("");
			Console.Write ("Domain: ");
			domain = Console.ReadLine();
			Console.Write ("Email: ");
			email = Console.ReadLine();
			Console.Write ("Password (will be visible): ");
			password = Console.ReadLine();
		}
		
		#endregion
		
		public static void RunAccuClassExample()
		{
			var loginRes = EngineericaApi.AccuClass.Login.Execute(domain, email, password, "token");
			if (!loginRes.Succeed) {
				Console.WriteLine("Unable to login. " + loginRes.ResponseText);
				return;
			}
			Console.WriteLine ("Logged in as: " + loginRes.Response.FullName);
			Console.WriteLine ();
			Console.WriteLine ();
			Console.WriteLine ();
			var res = EngineericaApi.AccuClass.Classroom.List(0, 10);
			
			Console.WriteLine ("First 10 classrooms: ");
			foreach (var cl in res.Response.results)
			{
				Console.WriteLine (" - " + cl.Name);
			}
		}
		
		public static void RunAccuClassExportExample()
		{
			var loginRes = EngineericaApi.AccuClass.Login.Execute(domain, email, password, "token");
			if (!loginRes.Succeed) {
				Console.WriteLine("Unable to login. " + loginRes.ResponseText);
				return;
			}
			Console.WriteLine ("Logged in as: " + loginRes.Response.FullName);
			Console.WriteLine ();
			Console.WriteLine ();
			Console.WriteLine ();
						
			var exp = EngineericaApi.AccuClass.Export.Execute(ExportType.Students, "HTML", "");
			
			var jobId = new Guid(exp.Response.JobId.ToString());
			do {
				Console.Clear();
				Console.WriteLine("Monitoring Job #" + jobId);
				Console.WriteLine();
				Console.WriteLine("--------------------------------------------------");
				
				System.Threading.Thread.Sleep(1000);
				var res = EngineericaApi.AccuClass.Bgjob.Getstatus(jobId, null);
				
				foreach (var r in res.Response.results[0].Statuses)
				{
					Console.WriteLine(r.Message);
				}
				
				// Check it's completed
				if (res.Response.results[0].Succeed.Value) break;
			} while(true);
			
			Console.WriteLine("--------------------------------------------------");
			Console.WriteLine();
			Console.WriteLine("==> Data ready, opening file...");
			System.Diagnostics.Process.Start("http://www.accuclass.net/JobResults/" + jobId + ".html");
		}
		
		public static void ViewAccuClassAttendanceExample()
		{
			Console.Clear();
			Console.WriteLine ("Enter user id (36 characters): ");
			var userId = new Guid(Console.ReadLine ());
			
			Console.Clear();
			var loginRes = EngineericaApi.AccuClass.Login.Execute(domain, email, password, "token");
			if (!loginRes.Succeed) {
				Console.WriteLine("Unable to login. " + loginRes.ResponseText);
				return;
			}
			
			var user = EngineericaApi.AccuClass.Enrollment.Getuser(userId);
			
			Console.WriteLine ("Enrollment for: \t" + user.Response.Student.FullName);
			Console.WriteLine ("In semester: \t" + user.Response.Semester.Name);
			foreach(var cl in user.Response.Classes)
			{
				Console.WriteLine ("------------------------------------------------------");
				Console.WriteLine (cl.Name + ":");
				var att = EngineericaApi.AccuClass.Attendancelog.Getuser(userId, new Guid(cl.Id.Value));
				foreach (var attres in att.Response.results)
				{
					Console.WriteLine(" - " + attres.Key + ": " + attres.@Value);
				}
			}
		}
		
		public static void RunCTExample()
		{
			var loginRes = EngineericaApi.ConferenceTracker.Login.Execute(domain, email, password, "token");
			if (!loginRes.Succeed) {
				Console.WriteLine("Unable to login. " + loginRes.ResponseText);
				return;
			}
			Console.WriteLine ("Logged in as: " + loginRes.Response.FullName);
			Console.WriteLine ();
			Console.WriteLine ();
			Console.WriteLine ();
			var res = EngineericaApi.ConferenceTracker.Room.List(0, 10);
			
			Console.WriteLine ("First 10 rooms: ");
			foreach (var cl in res.Response.results)
			{
				Console.WriteLine (" - " + cl.Name);
			}
		}
		
		public static void RunAccuWBExample()
		{
			var loginRes = EngineericaApi.AccuWB.Login.Execute(domain, email, password, "token");
			if (!loginRes.Succeed) {
				Console.WriteLine("Unable to login. " + loginRes.ResponseText);
				return;
			}
			Console.WriteLine ("Logged in as: " + loginRes.Response.FullName);
			Console.WriteLine ();
			Console.WriteLine ();
			Console.WriteLine ();
			var res = EngineericaApi.AccuWB.Room.List(0, 10);
			
			Console.WriteLine ("First 10 rooms: ");
			foreach (var cl in res.Response.results)
			{
				Console.WriteLine (" - " + cl.Name);
			}
		}
	}
}
