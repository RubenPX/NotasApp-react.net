using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ReactApp1.Server.Domain {
    public class CodeExceptionDTO{
        public int Code { get; }
        public string Message { get; }

        public CodeExceptionDTO(CodeException ex) {
            this.Code = ex.Code;
            this.Message = ex.Message;
        }

        public static IActionResult generateResponse(ControllerBase controller, Exception ex) {
            // Verify instance type
            if (ex.GetType() != typeof(CodeException)) throw ex;
            
            // Cast type & instance DTO
            CodeExceptionDTO dto = new CodeExceptionDTO((CodeException)ex);

            // Generate posible responses
            if (dto.Code == 404) return controller.NotFound(dto);
            
            return controller.Problem(dto.Message, "CodeException", 500);
        }
    }
}
