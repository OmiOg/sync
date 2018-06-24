namespace XIVAnalysis.Sync.Entities.Responses
{
    /// <summary>
    /// A response object from a Web Request that returns JSON
    /// </summary>
    public class JSONWebResponse : WebResponse
    {
        /// <summary>
        /// The JSON String
        /// </summary>
        public string JSONResult { get; set; }
    }
}
