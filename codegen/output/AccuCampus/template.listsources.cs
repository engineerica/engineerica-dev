using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Lists the templates' data sources.  This action requires authentication.
		/// </summary>
		/// <param name="@kind">The kind of the templates to return. It must be included in (badge, certificate).</param>


		public static ActionResult Listsources(string @kind
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "template.listsources", new {@kind
});
		}

		

	}
}


