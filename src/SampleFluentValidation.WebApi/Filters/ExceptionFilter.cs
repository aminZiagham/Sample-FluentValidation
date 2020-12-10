using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Data;
using System.Linq;

namespace SampleFluentValidation.WebApi.Filters
{
    public class ValidateModelStateAttribute : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if ((context.Exception as ValidationException) != null)
            {
                var result = new ContentResult();
                 var validationsfailures = (context.Exception as ValidationException).Errors;
                var errors = validationsfailures
                    .Select(v => v.ErrorMessage)
                    .ToList();

                var responseObj = new
                {
                    Message = "Bad Request",
                    Errors = errors                    
                };

                context.Result = new JsonResult(responseObj)
                {
                    StatusCode = 400
                };
            }
        }
    }
}
