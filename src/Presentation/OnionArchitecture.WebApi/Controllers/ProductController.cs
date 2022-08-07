using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using OnionArchitecture.Application.Interfaces.Repositories;
using OnionArchitecture.Application.Interfaces.UnitOfWork;
using OnionArchitecture.Domain.Entities;

namespace OnionArchitecture.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Product> allProducts = await _productRepository.GetAsync();
            return Ok(allProducts);
        }


        [HttpPost]
        public async Task<IActionResult> Post()
        {
            using IDbContextTransaction transaction = await _unitOfWork.BeginTransactionAsync();
            var resultData = await _unitOfWork.ProductRepository.AddAsync(new Product { Id = Guid.NewGuid(), Description = "Product 2 Description", Name = "Product 3 Name", Price = 3000, Stock = 30 });
            await transaction.CommitAsync();
            return Ok();
        }
    }
}
