using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Captchas.
	/// </summary>
	public partial class Captcha : ActionSet
	{
		
		/// <summary>
		/// Gets a captcha challenge that the user must complete to do certain requests.
		/// </summary>


		public ActionResult Getchallenge(
)
		{
			
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "captcha.getchallenge", new {
});
		}

		

	}
}


