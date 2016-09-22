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
		/// Lists the defined templates.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@kind">The kind of the templates to return. It must be included in (badge, certificate).</param>


		public static ActionResult List(int @from, int @count, string @kind
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "template.list", new {@from, @count, @kind
});
		}

		
		/// <summary>
		/// Lists the defined templates
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@kind">The kind of the templates to return. It must be included in (badge, certificate).</param>
		/// <param name="@designedonly">If true then it only returns the templates that were designed. Otherwise, it returns all.</param>


		public static ActionResult List(int @from, int @count, string @kind, bool @designedonly
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "template.list", new {@from, @count, @kind, @designedonly
});
		}

		

	}
}


