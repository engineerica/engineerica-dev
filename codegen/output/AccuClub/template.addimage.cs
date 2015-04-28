using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Adds an image to a template.  This action requires authentication.
		/// </summary>
		/// <param name="@template">The id of the template where the image has to be added</param>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>


		public static ActionResult Addimage(Guid @template, string @upload
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "template.addimage", new {@template, @upload
});
		}

		
		/// <summary>
		/// Adds an image to a template
		/// </summary>
		/// <param name="@template">The id of the template where the image has to be added</param>
		/// <param name="@upload">Set 'file' as value to indicate that a file is being submitted in the body (instead of a JSON object).</param>
		/// <param name="@filename">The local name of the uploaded file. For later reference.</param>


		public static ActionResult Addimage(Guid @template, string @upload, string @filename
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "template.addimage", new {@template, @upload, @filename
});
		}

		

	}
}


