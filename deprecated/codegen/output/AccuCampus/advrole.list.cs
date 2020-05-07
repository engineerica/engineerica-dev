using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Advroles.
	/// </summary>
	public static partial class Advrole
	{
		
		/// <summary>
		/// Lists the roles for the current account.  This action requires authentication.
		/// </summary>


		public static ActionResult List(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "advrole.list", new {
});
		}

		
		/// <summary>
		/// Lists the roles for the current account
		/// </summary>
		/// <param name="@includepolicies">True to include the policies, defaults to false.</param>
		/// <param name="@includeinternal">True to include the internal roles too.</param>
		/// <param name="@name">Filter by name of the role.</param>


		public static ActionResult List(bool @includepolicies, bool @includeinternal, string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "advrole.list", new {@includepolicies, @includeinternal, @name
});
		}

		

	}
}


