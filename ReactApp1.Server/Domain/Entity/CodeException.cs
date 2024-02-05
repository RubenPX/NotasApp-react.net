namespace ReactApp1.Server.Domain.Entity
{
    public class CodeException : Exception
    {
        public int Code { get; }
        public CodeException(int code, string? message) : base(message)
        {
            Code = code;
        }
    }
}
