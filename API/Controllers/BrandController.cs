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
    public class BrandController : ControllerBase
    {
        private readonly ILogger<BrandController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BrandController(ILogger<BrandController> logger, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Brand>>> GetAvailableBrands()
        {
            return Ok(await _unitOfWork.Brands.All());
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateBrand([FromBody] CreateBrandDTO data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessage());
            }

            var _mapped = _mapper.Map<Brand>(data);

            await _unitOfWork.Brands.Add(_mapped);
            await _unitOfWork.CompleteAsync();

            return CreatedAtRoute(nameof(GetBrandById), new { id = _mapped.Id }, _mapped);
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<Brand>> GetBrandById(int id)
        {
            return Ok(await _unitOfWork.Brands.GetById(id));
        }
    }
}
