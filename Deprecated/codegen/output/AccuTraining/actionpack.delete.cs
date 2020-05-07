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
		/// Delete an action pack.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the action pack to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "actionpack.delete", new {@id
});
		}

		

	}
}


