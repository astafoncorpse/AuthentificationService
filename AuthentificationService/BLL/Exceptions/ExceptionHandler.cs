using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Reflection;

namespace AuthentificationService.BLL.Exceptions
{
    public class ExceptionHandler : ActionFilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string message = "Произошла непредвиденная ошибка, Администрация спешит на помощь!";

            if (context.Exception.Message is CustomAttributeFormatException)
            {
                message = context.Exception.Message;
            }
            context.Result = new BadRequestObjectResult(message);
        }


    }
}
