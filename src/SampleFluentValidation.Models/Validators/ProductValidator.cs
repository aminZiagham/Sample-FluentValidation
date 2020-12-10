using FluentValidation;
using SampleFluentValidation.Models.Domains;

namespace SampleFluentValidation.Models.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(query => query.Id).NotEmpty().NotNull();
            RuleFor(query => query.ProductName).NotEmpty().NotNull().WithMessage("{PropertyName} should be not empty. NEVER!");;
            RuleFor(query => query.CreationDate).NotEmpty().NotNull();
        }
    }
}
