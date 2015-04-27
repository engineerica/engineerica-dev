using System;

namespace EngineericaApi.AccuTraining
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
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, false, "captcha.getchallenge", new {
});
		}

		

	}
}


