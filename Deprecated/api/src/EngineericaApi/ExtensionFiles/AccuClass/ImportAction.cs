using System.Collections.Generic;

namespace EngineericaApi.AccuClass
{
    public static partial class Import
    {
        /// <summary>
        /// Imports data to the system. This action requires authentication.
        /// </summary>
        /// <param name="fileName">The kind of data that is being uploaded.</param>
        public static ActionResult Execute(string fileName)
        {
            var args = new Dictionary<string, string> {{"importtype", "students"}, {"upload", "file"}, {"filename", fileName}};
            return ActionExecutor.ExecuteInternal(ConnectionInformation.AccuClass, true, "import", args, fileName);
        }
    }
}
