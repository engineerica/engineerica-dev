using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Emailtemplates.
	/// </summary>
	public static partial class Emailtemplate
	{
		
		/// <summary>
		/// Deletes an e-mail template.  This action requires authentication.
		/// </summary>
		/// <param name="@id">The id of the e-mail template to delete.</param>


		public static ActionResult Delete(Guid @id
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "emailtemplate.delete", new {@id
});
		}

		

	}
}


