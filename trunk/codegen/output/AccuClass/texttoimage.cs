using System;

namespace EngineericaApi.AccuClass
{
	/// <summary>
	/// Contains access to all the actions related to Texttoimages.
	/// </summary>
	public partial class Texttoimage : ActionSet
	{
		
		/// <summary>
		/// Generates a dynamic image from text.  This action requires authentication.
		/// </summary>
		/// <param name="_text">The text to convert to an image, use double pipes (||) as a new line.</param>


		public ActionResult Execute(string _text
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "texttoimage", new {_text
});
		}

		
		/// <summary>
		/// Generates a dynamic image from text
		/// </summary>
		/// <param name="_text">The text to convert to an image, use double pipes (||) as a new line.</param>
		/// <param name="_fontcolor">The color of the text, in hex format, without the #.</param>
		/// <param name="_fontsize">The size of the text, in points.</param>
		/// <param name="_direction">Either vertical or horizontal, default horizontal.</param>
		/// <param name="_width">The image width in pixels (or height if the direction is vertical).</param>


		public ActionResult Execute(string _text, string _fontcolor, int _fontsize, string _direction, int _width
)
		{
			EnsureIsAuthenticated();
			return ExecuteActionInternal(ConnectionInformation.AccuClass, "texttoimage", new {_text, _fontcolor, _fontsize, _direction, _width
});
		}

		

	}
}


