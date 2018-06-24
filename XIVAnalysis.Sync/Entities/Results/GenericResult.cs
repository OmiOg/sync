namespace XIVAnalysis.Sync.Entities.Results
{
    /// <summary>
    /// Generic Result all functions return, instead of Exceptions
    /// </summary>
    /// <typeparam name="TErrorCode"></typeparam>
    public class GenericResult<TErrorCode>
    {
        #region Properties

        /// <summary>
        /// Message returned to Caller, this should be a friendly message that could be used
        /// In a UI
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Denotes that an Operation executed without exceptions
        /// This does not indicate you got your desired result
        /// </summary>
        public bool IsSuccess { get; set; }
        /// <summary>
        /// Error Code to return to caller, helps automated decision making but isn't required
        /// </summary>
        public TErrorCode ErrorCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Always Initialize for optimistic Code flow
        /// </summary>
        public GenericResult()
        {
            Message = $"Operation Completed Successfully";
            IsSuccess = true;
        }

        #endregion
    }

    /// <summary>
    /// Generic Result allowing for a return object
    /// </summary>
    /// <typeparam name="TErrorCode"></typeparam>
    /// <typeparam name="T"></typeparam>
    public class GenericResult<TErrorCode, T> : GenericResult<TErrorCode>
    {
        #region Properties

        /// <summary>
        /// Holds the Return Value for this Result.
        /// </summary>
        public T Value { get; set; }

        #endregion

        #region Constructors

        public GenericResult() : base()
        {

        }

        #endregion
    }
}
