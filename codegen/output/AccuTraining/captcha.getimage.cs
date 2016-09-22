using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Captchas.
	/// </summary>
	public static partial class Captcha
	{
		
		/// <summary>
		/// Gets a captcha image that the user must complete to do certain requests.
		/// </summary>
		/// <param name="@captchatoken">The captcha token or ID returned by the captcha.getchallenge action</param>


		public static ActionResult Getimage(string @captchatoken
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, false, "captcha.getimage", new {@captchatoken
});
		}

		

	}
}


