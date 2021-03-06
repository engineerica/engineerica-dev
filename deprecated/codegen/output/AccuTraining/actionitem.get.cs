using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Actionitems.
	/// </summary>
	public static partial class Actionitem
	{
		
		/// <summary>
		/// Get an action item.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the action item to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "actionitem.get", new {@id
});
		}

		

	}
}


