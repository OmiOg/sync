using System.Net;

namespace XIVAnalysis.Sync.Entities.Responses
{
    /// <summary>
    /// Response from a Web Request
    /// </summary>
    public class WebResponse
    {
        /// <summary>
        /// HTTP Status Code returned from the Request
        /// </summary>
        public HttpStatusCode HttpStatusCode { get; set; }
    }
}
