using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Imports.
	/// </summary>
	public partial class Import : ActionSet
	{
		
		/// <summary>
		/// Imports data to the system..  This action requires authentication.
		/// </summary>
		/// <param name="_importtype">The kind of data that is being uploaded.</param>
		/// <param name="_upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>


		public ActionResult Execute(ImportType _importtype, string _upload
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "import", new {_importtype, _upload
});
		}

		
		/// <summary>
		/// Imports data to the system.
		/// </summary>
		/// <param name="_importtype">The kind of data that is being uploaded.</param>
		/// <param name="_upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="_filename">The local name of the uploaded file. For later reference.</param>


		public ActionResult Execute(ImportType _importtype, string _upload, string _filename
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "import", new {_importtype, _upload, _filename
});
		}

		

	}
}


