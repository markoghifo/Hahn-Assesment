using AutoMapper;
using Business.Data.Abstract;
using Business.Entities;
using Business.Helpers;
using Business.Models.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductController(ILogger<ProductController> logger, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetAvailableProducts()
        {
            return Ok(await _unitOfWork.Products.AllAvailable());
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCategory([FromBody] CreateProductDTO data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessage());
            }

            var _mapped = _mapper.Map<Product>(data);

            await _unitOfWork.Products.Add(_mapped);
            await _unitOfWork.CompleteAsync();

            return CreatedAtRoute(nameof(GetProductById), new { id = _mapped.Id }, _mapped);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<Product>> GetProductById(int id)
        {
            return Ok(await _unitOfWork.Products.GetById(id));
        }
    }
}
