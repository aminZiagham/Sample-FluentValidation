using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleFluentValidation.Models.Domains;
using SampleFluentValidation.Models.Validators;

namespace SampleFluentValidation.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            this._logger = logger;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            var validator = new ProductValidator();
            ValidationResult result = validator.Validate(product);

            if (result.IsValid)
                return Ok(product);

            throw new ValidationException(result.Errors);
        }

        [HttpDelete("{id}")]
        public void Put(int id)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}
