using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Actiontypes.
	/// </summary>
	public static partial class Actiontype
	{
		
		/// <summary>
		/// Save an action type.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the action type.</param>


		public static ActionResult Save(string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actiontype.save", new {@name
});
		}

		
		/// <summary>
		/// Save an action type
		/// </summary>
		/// <param name="@name">The name of the action type.</param>
		/// <param name="@id">The id of the action type to save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the action type.</param>


		public static ActionResult Save(string @name, Guid @id, string @description
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actiontype.save", new {@name, @id, @description
});
		}

		

	}
}


