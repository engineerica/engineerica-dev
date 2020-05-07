using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Waitinglines.
	/// </summary>
	public static partial class Waitingline
	{
		
		/// <summary>
		/// Delete a waiting line.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the line to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "waitingline.delete", new {@id
});
		}

		

	}
}


