using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Emailtemplates.
	/// </summary>
	public static partial class Emailtemplate
	{
		
		/// <summary>
		/// List e-mail base templates.  This action requires authentication.
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>


		public static ActionResult Listbase(int @from, int @count
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "emailtemplate.listbase", new {@from, @count
});
		}

		
		/// <summary>
		/// List e-mail base templates
		/// </summary>
		/// <param name="@from">The first record to return.</param>
		/// <param name="@count">The max number of records to return.</param>
		/// <param name="@forclasses">If set to true, returns only the templates that can be customized per class.</param>


		public static ActionResult Listbase(int @from, int @count, bool @forclasses
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "emailtemplate.listbase", new {@from, @count, @forclasses
});
		}

		

	}
}


