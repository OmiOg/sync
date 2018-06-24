using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using XIVAnalysis.Sync.Entities.Responses;
using XIVAnalysis.Sync.Entities.Results;

namespace XIVAnalysis.Sync.Repositories.Services
{
    public abstract class BaseServiceRepository
    {
        #region Properties

        /// <summary>
        /// Timeout on web requests.
        /// </summary>
        protected int _cancellationTimeout = 120000;

        #endregion

        #region Private Methods

        /// <summary>
        /// Creates a Cancellation Token so that we properly timeout and cleanup stuck web requests.
        /// </summary>
        /// <returns></returns>
        private CancellationToken GetCancellationToken()
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            cts.CancelAfter(_cancellationTimeout);
            return cts.Token;
        }

        #endregion

        #region Protected Methods

        #region GET

        #region Async

        #region Sans Token

        /// <summary>
        /// Executes a Get without the use of a Token in the Auth Header
        /// </summary>
        /// <typeparam name="TErrorCode"></typeparam>
        /// <param name="getUri"></param>
        /// <returns></returns>
        protected async Task<GenericResult<TErrorCode, JSONWebResponse>> ExecuteGet<TErrorCode>(Uri getUri)
        {
            return await ExecuteGet<TErrorCode>(getUri, String.Empty, String.Empty);
        }

        #endregion

        #region With Token

        /// <summary>
        /// Executes a Get utilitizing a Token in the Auth Header, note you must specify both the Token and it's type
        /// ie "Bearer"
        /// </summary>
        /// <typeparam name="TErrorCode"></typeparam>
        /// <param name="getUri"></param>
        /// <param name="token"></param>
        /// <param name="tokenType"></param>
        /// <returns></returns>
        protected async Task<GenericResult<TErrorCode, JSONWebResponse>> ExecuteGet<TErrorCode>(Uri getUri, string token, string tokenType)
        {
            var result = new GenericResult<TErrorCode, JSONWebResponse>() { Value = new JSONWebResponse() };

            try
            {
                using (var client = new HttpClient())
                {
                    //If you are getting an error that the communication channel was unexpectedly terminated uncomment this line, the issue is that
                    //they are using a potentially outdated channel type and your system default rejects it.
                    //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    //Defaulting to 10 minutes, you can cut this shorter by setting the global constant for cancellation timeout.
                    client.Timeout = new TimeSpan(0, 10, 0);

                    if (!String.IsNullOrEmpty(tokenType) && 
                        !String.IsNullOrEmpty(token))
                    {
                        //Set the Authorization information
                        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(tokenType, token);
                    }

                    var response = await client.GetAsync(getUri, GetCancellationToken());

                    //Fetch the Status Code
                    result.Value.HttpStatusCode = response.StatusCode;

                    //if response content was null an error occurred
                    if (response.Content == null)
                    {
                        result.IsSuccess = false;
                        result.Message = $"No Content returned in Web Response";
                    }
                    else
                    {
                        result.Value.JSONResult = await response.Content.ReadAsStringAsync();
                    }

                    //Dispose
                    response.Dispose();
                    //Nullify the Pointer, to help ensure it doesn't survive a collection as an inflight object.
                    response = null;
                }
            }
            catch (Exception ex)
            {
                result.Value = null;
                result.IsSuccess = false;
                //TODO: Real Handling here.
                result.Message = $"{ex.Message}";
            }

            return result;
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}
