using Event_System.Application.Core.Abstractions.Data;
using Event_System.Application.Core.Abstractions.Messaging;
using Event_System.Domain.Products;
using Event_System.Domain.Products.ValueObjects;

namespace Event_System.Application.Products.Commands.CreateProduct;

internal sealed class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, ProductDTO>
{
    private readonly IProductRepository _productRepository;
    private readonly IUnitOfWork _unitOfWork;

    public CreateProductCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
    {
        _productRepository = productRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<ProductDTO> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        Name name = Name.Create(request.Name);
        Description description = Description.Create(request.Description);
        Price price= Price.Create(request.Price);
        Stock stock = Stock.Create(request.Stock);
        List<string> items = request.Items;

        Product product = Product.Create(name, description, price, stock, items);

        // Validation

        await _productRepository.AddAsync(product, cancellationToken);

        await _unitOfWork.SaveChangesAsync(cancellationToken);


        return new(product.Name.Value, product.Description.Value, product.Price.Value, product.Stock.Value);
    }
}
