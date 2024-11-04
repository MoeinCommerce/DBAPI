namespace DatabaseApi.Exceptions
{
    public class InvalidFieldException : ExceptionModel
    {
        public InvalidFieldException(string field, string content)
        {
            Content = content;
            Field = field;
        }
    }
}