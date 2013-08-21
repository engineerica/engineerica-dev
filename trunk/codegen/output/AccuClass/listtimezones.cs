using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Listtimezoness.
	/// </summary>
	public partial class Listtimezones : ActionSet
	{
		
		/// <summary>
		/// Lists the available timezones
		/// </summary>


		public ActionResult Execute(
)
		{
			
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "listtimezones", new {
});
		}

		

	}
}


