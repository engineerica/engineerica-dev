using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Captchas.
	/// </summary>
	public static partial class Captcha
	{
		
		/// <summary>
		/// Gets a captcha challenge that the user must complete to do certain requests.
		/// </summary>


		public static ActionResult Getchallenge(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, false, "captcha.getchallenge", new {
});
		}

		

	}
}


