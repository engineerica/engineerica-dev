using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Clients.
	/// </summary>
	public static partial class Client
	{
		
		/// <summary>
		/// Saves a client.  This action requires authentication.
		/// </summary>
		/// <param name="@client">The id of the client to save.</param>
		/// <param name="@clientname">The name of the client.</param>


		public static ActionResult Save(Guid @client, string @clientname
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "client.save", new {@client, @clientname
});
		}

		
		/// <summary>
		/// Saves a client
		/// </summary>
		/// <param name="@client">The id of the client to save.</param>
		/// <param name="@clientname">The name of the client.</param>
		/// <param name="@pushtoken">The push token of the client.</param>


		public static ActionResult Save(Guid @client, string @clientname, string @pushtoken
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "client.save", new {@client, @clientname, @pushtoken
});
		}

		

	}
}


