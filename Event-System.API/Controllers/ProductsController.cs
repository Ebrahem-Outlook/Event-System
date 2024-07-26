using Event_System.API.Contracts.Product;
using Event_System.Application.Products.Commands.CreateProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Event_System.API.Controllers;

[Route("[Controller]/v1")]
[ApiController]
public sealed class ProductsController(ISender sender) : ControllerBase
{

    [HttpPost]
    public async Task<IActionResult> Create(CreateProductRequest request) =>
        Ok(await sender.Send(
            new CreateProductCommand(
                request.Name, 
                request.Description, 
                request.Price, 
                request.Stock, 
                request.Items)));

    
}
