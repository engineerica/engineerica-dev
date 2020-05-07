using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuClub
{
	/// <summary>
	/// Contains access to all the actions related to Credits.
	/// </summary>
	public static partial class Credit
	{
		
		/// <summary>
		/// Gets the valid discount methods.
		/// </summary>


		public static ActionResult Discountmethods(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClub, false, "credit.discountmethods", new {
});
		}

		

	}
}


