using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Emailtemplates.
	/// </summary>
	public static partial class Emailtemplate
	{
		
		/// <summary>
		/// Previews a template by id or by base template id.  This action requires authentication.
		/// </summary>


		public static ActionResult Preview(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "emailtemplate.preview", new {
});
		}

		
		/// <summary>
		/// Previews a template by id or by base template id
		/// </summary>
		/// <param name="@baseid">If set, this action will return the template defined for the specified base.</param>
		/// <param name="@clazzid">If set, the clazz information corresponding to this id is binded to the template.</param>
		/// <param name="@subjecttemplate">The template's subject value.</param>
		/// <param name="@bodytemplate">The template's body value.</param>


		public static ActionResult Preview(string @baseid, string @clazzid, string @subjecttemplate, string @bodytemplate
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "emailtemplate.preview", new {@baseid, @clazzid, @subjecttemplate, @bodytemplate
});
		}

		

	}
}


