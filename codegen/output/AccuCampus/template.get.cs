using System;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Templates.
	/// </summary>
	public static partial class Template
	{
		
		/// <summary>
		/// Gets a template.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the template to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "template.get", new {@id
});
		}

		

	}
}


