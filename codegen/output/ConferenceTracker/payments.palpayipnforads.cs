using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Paymentss.
	/// </summary>
	public static partial class Payments
	{
		
		/// <summary>
		/// Internal
		/// </summary>


		public static ActionResult Palpayipnforads(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, false, "payments.palpayipnforads", new {
});
		}

		

	}
}


