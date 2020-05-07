using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Supports.
	/// </summary>
	public static partial class Support
	{
		
		/// <summary>
		/// Uploads recovery information.  This action requires authentication.
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>


		public static ActionResult Uploaddb(string @upload
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "support.uploaddb", new {@upload
});
		}

		
		/// <summary>
		/// Uploads recovery information
		/// </summary>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@additionalinfo">Additional information to be associated with the database upload.</param>


		public static ActionResult Uploaddb(string @upload, string @additionalinfo
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "support.uploaddb", new {@upload, @additionalinfo
});
		}

		

	}
}


