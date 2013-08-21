using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Stations.
	/// </summary>
	public partial class Station : ActionSet
	{
		
		/// <summary>
		/// Unlocks the sign-in station.
		/// </summary>
		/// <param name="_id">The id of the sign-in station to unlock.</param>
		/// <param name="_passcode">The passcode to unlock the station.</param>
		/// <param name="_method">The authentication method. Valid values are 'token' and 'cookie'.</param>


		public ActionResult Unlock(Guid _id, string _passcode, string _method
)
		{
			
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "station.unlock", new {_id, _passcode, _method
});
		}

		

	}
}


