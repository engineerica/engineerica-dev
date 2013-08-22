using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Adds an image to a template.  This action requires authentication.
		/// </summary>
		/// <param name="@conference">The id of the conference whose template has to be saved.</param>
		/// <param name="@kind">The kind of the template. Valid values are Badge or Certificate.</param>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>


		public static ActionResult Addimage(string @conference, string @kind, string @upload
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "template.addimage", new {@conference, @kind, @upload
});
		}

		
		/// <summary>
		/// Adds an image to a template
		/// </summary>
		/// <param name="@conference">The id of the conference whose template has to be saved.</param>
		/// <param name="@kind">The kind of the template. Valid values are Badge or Certificate.</param>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@filename">The local name of the uploaded file. For later reference.</param>


		public static ActionResult Addimage(string @conference, string @kind, string @upload, string @filename
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "template.addimage", new {@conference, @kind, @upload, @filename
});
		}

		

	}
}


