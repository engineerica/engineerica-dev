using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Waitinglines.
	/// </summary>
	public static partial class Waitingline
	{
		
		/// <summary>
		/// Remove user from a waiting line.  This action requires authentication.
		/// </summary>
		/// <param name="@waitingline">The id of the waiting line whose item has to be removed.</param>
		/// <param name="@cardnumber">The card number of the item that has to be removed.</param>


		public static ActionResult Removeuser(Guid @waitingline, string @cardnumber
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "waitingline.removeuser", new {@waitingline, @cardnumber
});
		}

		

	}
}


