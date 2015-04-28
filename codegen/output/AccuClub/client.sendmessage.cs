using System;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Clients.
	/// </summary>
	public static partial class Client
	{
		
		/// <summary>
		/// Send a message to a client.  This action requires authentication.
		/// </summary>
		/// <param name="@uniqueclientid">The unique id of the client.</param>
		/// <param name="@message">The body of the message to send.</param>


		public static ActionResult Sendmessage(Guid @uniqueclientid, string @message
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, true, "client.sendmessage", new {@uniqueclientid, @message
});
		}

		

	}
}


