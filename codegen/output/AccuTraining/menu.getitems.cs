using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Menus.
	/// </summary>
	public static partial class Menu
	{
		
		/// <summary>
		/// Gets the items on the menu
		/// </summary>
		/// <param name="@menuid">The Id of the menu to get.</param>


		public static ActionResult Getitems(string @menuid
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, false, "menu.getitems", new {@menuid
});
		}

		

	}
}


