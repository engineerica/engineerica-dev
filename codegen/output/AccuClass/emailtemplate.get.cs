using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Emailtemplates.
	/// </summary>
	public static partial class Emailtemplate
	{
		
		/// <summary>
		/// Gets an e-mail template by id or by base template id.  This action requires authentication.
		/// </summary>


		public static ActionResult Get(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "emailtemplate.get", new {
});
		}

		
		/// <summary>
		/// Gets an e-mail template by id or by base template id
		/// </summary>
		/// <param name="@baseid">If set, this action will return the template defined for the specified base.</param>
		/// <param name="@clazzid">If set, this action will return the template defined for the specified class.</param>
		/// <param name="@status">If set, this action will return the template defined for the specified status.</param>


		public static ActionResult Get(string @baseid, string @clazzid, string @status
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "emailtemplate.get", new {@baseid, @clazzid, @status
});
		}

		

	}
}


