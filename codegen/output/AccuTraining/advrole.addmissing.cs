using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Advroles.
	/// </summary>
	public static partial class Advrole
	{
		
		/// <summary>
		/// Adds the missing permissions to a role. Requires access to advrole.save.  This action requires authentication.
		/// </summary>
		/// <param name="@roles">CSV list of the role ids to check</param>
		/// <param name="@permissions">CSV list of the permissions to check</param>


		public static ActionResult Addmissing(string @roles, string @permissions
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "advrole.addmissing", new {@roles, @permissions
});
		}

		

	}
}


