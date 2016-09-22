using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Saves a template.  This action requires authentication.
		/// </summary>
		/// <param name="@kind">The kind of the templates to return. It must be included in (badge, certificate).</param>
		/// <param name="@name">The template's name.</param>


		public static ActionResult Save(string @kind, string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "template.save", new {@kind, @name
});
		}

		
		/// <summary>
		/// Saves a template
		/// </summary>
		/// <param name="@kind">The kind of the templates to return. It must be included in (badge, certificate).</param>
		/// <param name="@name">The template's name.</param>
		/// <param name="@id">The id of the template to save (leave empty to create a new one).</param>
		/// <param name="@description">The template's description.</param>


		public static ActionResult Save(string @kind, string @name, Guid @id, string @description
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "template.save", new {@kind, @name, @id, @description
});
		}

		

	}
}


