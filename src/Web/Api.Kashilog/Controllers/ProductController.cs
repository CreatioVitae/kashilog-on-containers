using Api.Kashilog.Services.Kashi;
using DomainObject.Kashilog.Kashi.QueryResults;

namespace Api.Kashilog.Controllers; 

[ApiController]
[Route("product")]
public class ProductController(ProductService productService) : ControllerBase {

    private ProductService ProductService { get; } = productService;

    [HttpGet]
    public async ValueTask<ActionResult> GetProducts() =>
        this.CreateHttpGetResult(await ProductService.GetAllProductsAsync());

    [HttpGet("i-async-enumerable-test")]
    public IAsyncEnumerable<ProductResult> GetProducts2() =>
        ProductService.GetAllProductsAsyncUsingIAsyncEnumerable();

    [HttpGet("{ productId:int:min(1) }")]
    public async ValueTask<ActionResult> GetProduct(int productId) =>
        this.CreateHttpGetResult(await ProductService.GetProductByIdAsync(productId));
}
