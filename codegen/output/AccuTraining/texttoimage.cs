using System;

namespace EngineericaApi.AccuTraining
{
	/// <summary>
	/// Contains access to all the actions related to Texttoimages.
	/// </summary>
	public static partial class Texttoimage
	{
		
		/// <summary>
		/// Generates a dynamic image from text.  This action requires authentication.
		/// </summary>
		/// <param name="@text">The text to convert to an image, use double pipes (||) as a new line.</param>


		public static ActionResult Execute(string @text
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "texttoimage", new {@text
});
		}

		
		/// <summary>
		/// Generates a dynamic image from text
		/// </summary>
		/// <param name="@text">The text to convert to an image, use double pipes (||) as a new line.</param>
		/// <param name="@fontcolor">The color of the text, in hex format, without the #.</param>
		/// <param name="@fontsize">The size of the text, in points.</param>
		/// <param name="@direction">Either vertical or horizontal, default horizontal.</param>
		/// <param name="@width">The image width in pixels (or height if the direction is vertical).</param>


		public static ActionResult Execute(string @text, string @fontcolor, int @fontsize, string @direction, int @width
)
		{
			return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuTraining, true, "texttoimage", new {@text, @fontcolor, @fontsize, @direction, @width
});
		}

		

	}
}


