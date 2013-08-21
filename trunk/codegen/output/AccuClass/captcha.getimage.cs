using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Captchas.
	/// </summary>
	public partial class Captcha : ActionSet
	{
		
		/// <summary>
		/// Gets a captcha image that the user must complete to do certain requests.
		/// </summary>
		/// <param name="_captchatoken">The captcha token or ID returned by the captcha.getchallenge action</param>


		public ActionResult Getimage(string _captchatoken
)
		{
			
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "captcha.getimage", new {_captchatoken
});
		}

		

	}
}


