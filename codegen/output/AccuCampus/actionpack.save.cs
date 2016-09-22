using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Actionpacks.
	/// </summary>
	public static partial class Actionpack
	{
		
		/// <summary>
		/// Save an action pack.  This action requires authentication.
		/// </summary>
		/// <param name="@code">The code of the action pack.</param>
		/// <param name="@name">The name of the action pack.</param>


		public static ActionResult Save(string @code, string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actionpack.save", new {@code, @name
});
		}

		
		/// <summary>
		/// Save an action pack
		/// </summary>
		/// <param name="@code">The code of the action pack.</param>
		/// <param name="@name">The name of the action pack.</param>
		/// <param name="@id">The id of the action pack to save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the action pack.</param>
		/// <param name="@items">A JSON array containing the ids of the action items that belong to this pack</param>


		public static ActionResult Save(string @code, string @name, Guid @id, string @description, bool @items
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "actionpack.save", new {@code, @name, @id, @description, @items
});
		}

		

	}
}


