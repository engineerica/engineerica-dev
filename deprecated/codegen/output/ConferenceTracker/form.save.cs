using System;

namespace EngineericaApi.ConferenceTracker
{
	/// <summary>
	/// Contains access to all the actions related to Forms.
	/// </summary>
	public static partial class Form
	{
		
		/// <summary>
		/// Save form.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the form</param>
		/// <param name="@conference">The id of the conference whose form layout has to be saved.</param>
		/// <param name="@layout">The form's layout (in JSON).</param>


		public static ActionResult Save(string @name, string @conference, string @layout
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "form.save", new {@name, @conference, @layout
});
		}

		
		/// <summary>
		/// Save form
		/// </summary>
		/// <param name="@name">The name of the form</param>
		/// <param name="@conference">The id of the conference whose form layout has to be saved.</param>
		/// <param name="@layout">The form's layout (in JSON).</param>
		/// <param name="@id">The id of the form to save (leave empty to create a new one).</param>


		public static ActionResult Save(string @name, string @conference, string @layout, Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.ConferenceTracker, true, "form.save", new {@name, @conference, @layout, @id
});
		}

		

	}
}


