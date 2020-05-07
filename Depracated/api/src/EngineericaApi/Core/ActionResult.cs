using Newtonsoft.Json;

namespace EngineericaApi
{
	public class ActionResult
	{
		public ActionResult (string responseText)
		{
			ResponseText = responseText;
			Deserialize();
		}
		
		public string ResponseText { get; set; }
		public dynamic Response { get; set; }
				
		/// <summary>
		/// Gets a value indicating whether the action executed succeed or not.
		/// </summary>
		/// <value>
		/// <c>true</c> if succeed; otherwise, <c>false</c>.
		/// </value>
		public bool Succeed {
			get {
				return Response.success;
			}
		}
		
		private void Deserialize()
		{
			Response = JsonConvert.DeserializeObject(ResponseText);
		}
	}
}

