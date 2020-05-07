using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Actionpacks.
	/// </summary>
	public static partial class Actionpack
	{
		
		/// <summary>
		/// Get an action pack.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the action pack to get.</param>


		public static ActionResult Get(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "actionpack.get", new {@id
});
		}

		

	}
}


