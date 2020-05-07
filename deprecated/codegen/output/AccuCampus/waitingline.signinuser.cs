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
		/// Sign a user in from a waiting line.  This action requires authentication.
		/// </summary>
		/// <param name="@waitingline">The id of the waiting line whose item needs to be signed-in.</param>
		/// <param name="@cardnumber">The card number of the item that has to be signed-in.</param>
		/// <param name="@staff">The id of the staff member selected to sign-in.</param>


		public static ActionResult Signinuser(Guid @waitingline, string @cardnumber, Guid @staff
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "waitingline.signinuser", new {@waitingline, @cardnumber, @staff
});
		}

		
		/// <summary>
		/// Sign a user in from a waiting line
		/// </summary>
		/// <param name="@waitingline">The id of the waiting line whose item needs to be signed-in.</param>
		/// <param name="@cardnumber">The card number of the item that has to be signed-in.</param>
		/// <param name="@staff">The id of the staff member selected to sign-in.</param>
		/// <param name="@photosize">The swiping user's photo size.</param>


		public static ActionResult Signinuser(Guid @waitingline, string @cardnumber, Guid @staff, int @photosize
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "waitingline.signinuser", new {@waitingline, @cardnumber, @staff, @photosize
});
		}

		

	}
}


