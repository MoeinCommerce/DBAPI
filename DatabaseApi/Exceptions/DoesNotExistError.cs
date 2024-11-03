using System;

namespace DatabaseApi.Exceptions
{
    public class DoesNotExistError : ExceptionModel
    {
        public DoesNotExistError(string content)
        {
            Content = content;
        }
    }
}