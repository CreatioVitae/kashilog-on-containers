using DomainObject.Kashilog.Kashi.QueryResults;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Kashilog.Services.Kashi;
using WebApiPack.Controllers;

namespace Api.Kashilog.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase {

        private ProductService ProductService { get; }

        public ProductController(ProductService productService) => ProductService = productService;

        [HttpGet]
        public async ValueTask<ActionResult> GetProducts() => this.CreateHttpGetResult(await ProductService.GetAllProductsAsync());

        [HttpGet("i-async-enumerable-test")]
        public IAsyncEnumerable<ProductResult> GetProducts2() => ProductService.GetAllProductsAsyncUsingIAsyncEnumerable();

        [HttpGet("{productId:int:min(1)}")]
        public async ValueTask<ActionResult> GetProduct(int productId) => this.CreateHttpGetResult(await ProductService.GetProductByIdAsync(productId));
    }
}
