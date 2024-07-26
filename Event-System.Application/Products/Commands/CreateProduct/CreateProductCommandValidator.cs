using FluentValidation;

namespace Event_System.Application.Products.Commands.CreateProduct;

internal sealed class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
{
    public CreateProductCommandValidator()
    {
        RuleFor(c => c.Name).NotNull().NotEmpty().WithMessage("Customer Name can't be null or empty.");

        RuleFor(c => c.Description).NotNull().NotEmpty().WithMessage("Customer Description can't be null or empty.");

        RuleFor(c => c.Price).NotNull().NotEmpty().WithMessage("Customer Price can't be null or empty.");

        RuleFor(c => c.Stock).NotNull().NotEmpty().WithMessage("Customer Stock can't be null or empty.");

        RuleFor(c => c.Items).NotNull().NotEmpty().WithMessage("Customer Items can't be null or empty.");
    }
}
