namespace ReactApp1.Server.Domain {
    public class CodeException : Exception {
        public int Code { get; }
        public CodeException(int code, string? message) : base(message) {
            this.Code = code;
        }
    }
}
