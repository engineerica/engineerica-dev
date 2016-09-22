using System;
using EngineericaApi.ExtensionFiles.CommonTypes;

namespace EngineericaApi.AccuCampus
{
	/// <summary>
	/// Contains access to all the actions related to Notificationtopics.
	/// </summary>
	public static partial class Notificationtopic
	{
		
		/// <summary>
		/// Save a notification topic.  This action requires authentication.
		/// </summary>
		/// <param name="@name">The name of the topic.</param>
		/// <param name="@description">The description of the topic.</param>


		public static ActionResult Save(string @name, string @description
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "notificationtopic.save", new {@name, @description
});
		}

		
		/// <summary>
		/// Save a notification topic
		/// </summary>
		/// <param name="@name">The name of the topic.</param>
		/// <param name="@description">The description of the topic.</param>
		/// <param name="@id">The id of the topic to save (leave empty to create a new one).</param>
		/// <param name="@enableonscreendelivery">Specifies whether the notifications assigned to this topic can be sent on-screen or not.</param>
		/// <param name="@sendonscreendefault">Specifies whether the notifications assigned to this topic have to have the on-screen delivery enabled by default.</param>
		/// <param name="@enableemaildelivery">Specifies whether the notifications assigned to this topic can be sent via e-mail or not.</param>
		/// <param name="@sendemaildefault">Specifies whether the notifications assigned to this topic have to have the e-mail delivery enabled by default.</param>
		/// <param name="@enablesmsdelivery">Specifies whether the notifications assigned to this topic can be sent via sms or not.</param>
		/// <param name="@sendsmsdefault">Specifies whether the notifications assigned to this topic have to have the sms delivery enabled by default.</param>


		public static ActionResult Save(string @name, string @description, Guid @id, bool @enableonscreendelivery, bool @sendonscreendefault, bool @enableemaildelivery, bool @sendemaildefault, bool @enablesmsdelivery, bool @sendsmsdefault
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuCampus, true, "notificationtopic.save", new {@name, @description, @id, @enableonscreendelivery, @sendonscreendefault, @enableemaildelivery, @sendemaildefault, @enablesmsdelivery, @sendsmsdefault
});
		}

		

	}
}


