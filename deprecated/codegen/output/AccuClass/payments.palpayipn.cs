using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Paymentss.
	/// </summary>
	public static partial class Payments
	{
		
		/// <summary>
		/// Internal
		/// </summary>


		public static ActionResult Palpayipn(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, false, "payments.palpayipn", new {
});
		}

		

	}
}


