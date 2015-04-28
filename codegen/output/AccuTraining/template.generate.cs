using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Generates specified templates..  This action requires authentication.
		/// </summary>
		/// <param name="@template">The id of the template to generate.</param>
		/// <param name="@source">The source key of the selected template data source.</param>
		/// <param name="@singlefile">True if all the templates should be placed in the same file, false if each one shoud be in its own file.</param>


		public static ActionResult Generate(Guid @template, Guid @source, bool @singlefile
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "template.generate", new {@template, @source, @singlefile
});
		}

		
		/// <summary>
		/// Generates specified templates.
		/// </summary>
		/// <param name="@template">The id of the template to generate.</param>
		/// <param name="@source">The source key of the selected template data source.</param>
		/// <param name="@singlefile">True if all the templates should be placed in the same file, false if each one shoud be in its own file.</param>
		/// <param name="@userid">Only the template for these users is created (and emailed if 'email' is true), enter multiple separated by commas.</param>
		/// <param name="@forsending">It specifies the purpose of the creation of the templates. If true then is for sending via e-mail, otherwise is just for downloading</param>
		/// <param name="@role">When printing all badges, filter by person type, can be either: attendee, presenter or exhibitor</param>
		/// <param name="@filters">Pipe separated filters for the generation, eg: aaa=val|bbb=val|...</param>


		public static ActionResult Generate(Guid @template, Guid @source, bool @singlefile, string @userid, bool @forsending, Guid @role, string @filters
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "template.generate", new {@template, @source, @singlefile, @userid, @forsending, @role, @filters
});
		}

		

	}
}


