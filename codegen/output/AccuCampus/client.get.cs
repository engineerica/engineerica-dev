using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Clients.
	/// </summary>
	public static partial class Client
	{
		
		/// <summary>
		/// Get client.  This action requires authentication.
		/// </summary>
		/// <param name="@client">The unique id of the client.</param>


		public static ActionResult Get(string @client
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "client.get", new {@client
});
		}

		
		/// <summary>
		/// Get client
		/// </summary>
		/// <param name="@client">The unique id of the client.</param>
		/// <param name="@clientname">The custom name of the client.</param>


		public static ActionResult Get(string @client, string @clientname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "client.get", new {@client, @clientname
});
		}

		

	}
}


