using System;

namespace DatabaseApi.Exceptions
{
    public class ValidationError : ExceptionModel
    {
        public ValidationError(string field, string content)
        {
            Content = content;
            Field = field;
        }
    }
}