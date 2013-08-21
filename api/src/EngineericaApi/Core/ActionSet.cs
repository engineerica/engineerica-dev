using System;
using System.Net;
using System.IO;

namespace EngineericaApi
{
	public class ActionSet
	{
		protected internal string _token;
		protected internal ActionResult ExecuteActionInternal(ConnectionInformation conn, string action, object args)
		{
			WebRequest req = HttpWebRequest.Create(conn.ServiceUrl + "Service/?action=" + action);
			var resp = req.GetResponse();
			try
			{
				using (var stream = resp.GetResponseStream())
				using (var reader = new StreamReader(stream))
				{
					var str = reader.ReadToEnd();
					return new ActionResult { ResponseText = str };
				}
			}
			finally
			{
				resp.Close();
			}
		}
		
		public void EnsureIsAuthenticated ()
		{
			// NOT IMPLEMENTED
		}
		
	}
}

