using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Docs.
	/// </summary>
	public static partial class Doc
	{
		
		/// <summary>
		/// Get Documentation
		/// </summary>


		public static ActionResult Execute(
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, false, "doc", new {
});
		}

		

	}
}


