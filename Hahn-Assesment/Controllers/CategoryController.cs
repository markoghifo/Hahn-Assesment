using AutoMapper;
using Business.Data.Abstract;
using Business.Entities;
using Business.Helpers;
using Business.Models.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hahn_Assesment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private IMapper _mapper { get; }

        public CategoryController(ILogger<CategoryController> logger, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet("[action]")]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
        {
            return Ok(await _unitOfWork.Categories.All());
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDTO data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState.GetErrorMessage());
            }

            var _mapped = _mapper.Map<Category>(data);

            await _unitOfWork.Categories.Add(_mapped);
            await _unitOfWork.CompleteAsync();

            return CreatedAtRoute("GetCategory", new { id = _mapped.Id }, _mapped);
        }


        [HttpGet("[action]")]
        public async Task<ActionResult<Category>> GetCategory([FromQuery] int id)
        {
            return Ok(await _unitOfWork.Categories.GetById(id));
        }
    }
}
