using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Imports.
	/// </summary>
	public static partial class Import
	{
		
		/// <summary>
		/// Imports data to the system..  This action requires authentication.
		/// </summary>
		/// <param name="@importtype">The kind of data that is being uploaded.</param>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>


		public static ActionResult Execute(ImportType @importtype, string @upload
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "import", new {@importtype, @upload
});
		}

		
		/// <summary>
		/// Imports data to the system.
		/// </summary>
		/// <param name="@importtype">The kind of data that is being uploaded.</param>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@filename">The local name of the uploaded file. For later reference.</param>
		/// <param name="@formattings">A JSON-formatted array containing the formatting functions that have to be applied to the specified fields.</param>


		public static ActionResult Execute(ImportType @importtype, string @upload, string @filename, string @formattings
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "import", new {@importtype, @upload, @filename, @formattings
});
		}

		

	}
}


