// System
using System;


namespace DatabaseApi.Exceptions
{
    public class ExceptionModel : Exception
    {
        /// <summary>
        /// The name of the field associated with the exception.
        /// This property indicates the specific property or parameter that caused the exception.
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        /// The detailed message explaining the exception.
        /// This property provides information on why the exception was thrown, offering additional context for troubleshooting.
        /// </summary>
        public string Content { get; set; }
    }
}