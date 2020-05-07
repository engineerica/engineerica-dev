using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Tags.
	/// </summary>
	public static partial class Tag
	{
		
		/// <summary>
		/// Save a tag.  This action requires authentication.
		/// </summary>
		/// <param name="@group">The group id of the tag.</param>
		/// <param name="@name">The name of the tag.</param>


		public static ActionResult Save(string @group, string @name
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "tag.save", new {@group, @name
});
		}

		
		/// <summary>
		/// Save a tag
		/// </summary>
		/// <param name="@group">The group id of the tag.</param>
		/// <param name="@name">The name of the tag.</param>
		/// <param name="@id">The id of the tag save (leave empty to create a new one).</param>
		/// <param name="@description">The description of the tag.</param>
		/// <param name="@requestedby">The information regarding who requested this tag and who should use it.</param>
		/// <param name="@viewroles">The roles that can view the answers, in JSON format.</param>
		/// <param name="@editroles">The roles that can edit the answers, in JSON format.</param>
		/// <param name="@scopes">The scopes that have access to this questionnaire, in JSON format.</param>


		public static ActionResult Save(string @group, string @name, Guid @id, string @description, string @requestedby, string @viewroles, string @editroles, string @scopes
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "tag.save", new {@group, @name, @id, @description, @requestedby, @viewroles, @editroles, @scopes
});
		}

		

	}
}


