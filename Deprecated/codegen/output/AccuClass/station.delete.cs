using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Stations.
	/// </summary>
	public static partial class Station
	{
		
		/// <summary>
		/// Deletes a sign-in station.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the sign-in station to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "station.delete", new {@id
});
		}

		

	}
}


