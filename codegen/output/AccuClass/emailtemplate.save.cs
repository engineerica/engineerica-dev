using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Emailtemplates.
	/// </summary>
	public static partial class Emailtemplate
	{
		
		/// <summary>
		/// Saves an e-mail template.  This action requires authentication.
		/// </summary>
		/// <param name="@basetemplate">The id of the base template of the one to save.</param>
		/// <param name="@subject">The subject of the e-mails thast will be sent using this template.</param>


		public static ActionResult Save(string @basetemplate, string @subject
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "emailtemplate.save", new {@basetemplate, @subject
});
		}

		
		/// <summary>
		/// Saves an e-mail template
		/// </summary>
		/// <param name="@basetemplate">The id of the base template of the one to save.</param>
		/// <param name="@subject">The subject of the e-mails thast will be sent using this template.</param>
		/// <param name="@id">The id of the e-mail template to save (leave empty to create a new one).</param>
		/// <param name="@fromname">The name of the sender of the e-mails that will be sent using this template.</param>
		/// <param name="@replyto">The reply-to e-mail address.</param>
		/// <param name="@body">The body of the e-mails thast will be sent using this template.</param>
		/// <param name="@ishtml">Specifies whether this template is in html format.</param>
		/// <param name="@clazzid">The id of the clazz that owns this template.</param>
		/// <param name="@status">The status that this template is defined for.</param>


		public static ActionResult Save(string @basetemplate, string @subject, Guid @id, string @fromname, string @replyto, string @body, bool @ishtml, bool @clazzid, bool @status
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "emailtemplate.save", new {@basetemplate, @subject, @id, @fromname, @replyto, @body, @ishtml, @clazzid, @status
});
		}

		

	}
}


