namespace DatabaseApi.Exceptions
{
    public class DbInvalidFieldException : DbExceptionModel
    {
        public DbInvalidFieldException(string field, string content)
        {
            Content = content;
            Field = field;
        }
    }
}