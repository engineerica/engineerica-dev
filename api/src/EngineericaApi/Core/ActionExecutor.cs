using System;
using System.Net;
using System.IO;

namespace EngineericaApi
{
	internal static class ActionExecutor
	{
		public static ActionResult ExecuteInternal(ConnectionInformation conn, bool sendLoginToken, string action, object args)
		{
			var url = conn.ServiceUrl + "Service/?action=" + action;
			if (sendLoginToken)
			{
				EnsureIsAuthenticated(conn);
				url += "&token=" + conn.LoginToken;
			}
			
			WebRequest req = HttpWebRequest.Create(url);
			req.Method = "POST";
			using (var stream = req.GetRequestStream())
			using (var writer = new StreamWriter(stream))
			{
				Newtonsoft.Json.JsonSerializer.Create().Serialize(writer, args);
				writer.Flush();
			}
			
			var resp = req.GetResponse();
			try
			{
				using (var stream = resp.GetResponseStream())
				using (var reader = new StreamReader(stream))
				{
					var str = reader.ReadToEnd();
					var res = new ActionResult(str);
					
					if (action == "login")
					{
						conn.LoginToken = res.Response.token;
					}
					
					return res;
				}
			}
			finally
			{
				resp.Close();
			}
		}
		
		public static void EnsureIsAuthenticated (ConnectionInformation conn)
		{
			if (!conn.IsLoggedIn) throw new Exception("You must be logged in to execute this action.");
		}
		
	}
}

