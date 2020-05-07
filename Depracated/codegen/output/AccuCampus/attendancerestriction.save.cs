using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Attendancerestrictions.
	/// </summary>
	public static partial class Attendancerestriction
	{
		
		/// <summary>
		/// Save an attendance restriction.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the restriction.</param>
		/// <param name="@basis">The basis of the restriction (location, service or staff).</param>
		/// <param name="@restrictedobjects">A json array containing the ids of the objects to restrict.</param>
		/// <param name="@useristagged">Specifies whether the restriction should be set for users with or without the specified tag.</param>
		/// <param name="@show">Specifies whether the restriction should show or hide the specified objects.</param>
		/// <param name="@tag">The id of the tag to restrict</param>


		public static ActionResult Save(string @name, string @basis, string @restrictedobjects, bool @useristagged, bool @show, Guid @tag
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "attendancerestriction.save", new {@name, @basis, @restrictedobjects, @useristagged, @show, @tag
});
		}

		
		/// <summary>
		/// Save an attendance restriction
		/// </summary>
		/// <param name="@name">The name of the restriction.</param>
		/// <param name="@basis">The basis of the restriction (location, service or staff).</param>
		/// <param name="@restrictedobjects">A json array containing the ids of the objects to restrict.</param>
		/// <param name="@useristagged">Specifies whether the restriction should be set for users with or without the specified tag.</param>
		/// <param name="@show">Specifies whether the restriction should show or hide the specified objects.</param>
		/// <param name="@tag">The id of the tag to restrict</param>
		/// <param name="@id">The id of the restriction save (leave empty to create a new one).</param>
		/// <param name="@details">The details of the restriction.</param>
		/// <param name="@order">Specifies the order of precedence of the restriction.</param>
		/// <param name="@locations">A json array containing the ids of the location where this restriction applies.</param>


		public static ActionResult Save(string @name, string @basis, string @restrictedobjects, bool @useristagged, bool @show, Guid @tag, Guid @id, string @details, int @order, string @locations
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "attendancerestriction.save", new {@name, @basis, @restrictedobjects, @useristagged, @show, @tag, @id, @details, @order, @locations
});
		}

		

	}
}


