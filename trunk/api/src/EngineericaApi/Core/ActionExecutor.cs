using System;
using System.Collections.Generic;
using System.Net;
using System.IO;

namespace EngineericaApi
{
	internal static class ActionExecutor
	{
        private static ActionResult ExecuteInternal(ConnectionInformation conn, bool sendLoginToken, string action, IEnumerable<KeyValuePair<string, string>> queryArgs, object streamArgs, string filePathToUpload)
        {
            var url = conn.ServiceUrl + "Service/?action=" + action;
            if (sendLoginToken)
            {
                EnsureIsAuthenticated(conn);
                url += "&token=" + conn.LoginToken;
            }

            if (queryArgs != null)
            {
                foreach (var arg in queryArgs)
                {
                    url += "&" + arg.Key + "=" + arg.Value;
                }
            }

            var req = (HttpWebRequest) WebRequest.Create(url);
            req.Method = "POST";

            if (!string.IsNullOrEmpty(filePathToUpload))
            {
                using (var writer = req.GetRequestStream())
                using (var reader = File.OpenRead(filePathToUpload))
                {
                    int len;
                    var buffer = new byte[1024];
                    while ((len = reader.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        writer.Write(buffer, 0, len);
                    }
                    writer.Flush();
                }
            }
            else if (streamArgs != null)
            {
                using (var stream = req.GetRequestStream())
                using (var writer = new StreamWriter(stream))
                {
                    Newtonsoft.Json.JsonSerializer.Create().Serialize(writer, streamArgs);
                    writer.Flush();
                }
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
        
        public static ActionResult ExecuteInternal(ConnectionInformation conn, bool sendLoginToken, string action, IDictionary<string, string> queryArgs, object streamArgs)
        {
            return ExecuteInternal(conn, sendLoginToken, action, queryArgs, streamArgs, null);
        }

        public static ActionResult ExecuteInternal(ConnectionInformation conn, bool sendLoginToken, string action, IDictionary<string, string> queryArgs, string filePathToUpload)
        {
            return ExecuteInternal(conn, sendLoginToken, action, queryArgs, null, filePathToUpload);
        }
        
        public static ActionResult ExecuteInternal(ConnectionInformation conn, bool sendLoginToken, string action, object args)
        {
            return ExecuteInternal(conn, sendLoginToken, action, null, args);
        }
		
		public static void EnsureIsAuthenticated (ConnectionInformation conn)
		{
			if (!conn.IsLoggedIn) throw new Exception("You must be logged in to execute this action.");
		}
		
	}
}

