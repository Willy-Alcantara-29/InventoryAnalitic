using InventaryAnalitic.Domain.Entities.Csv;
using InventaryAnalitic.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InventaryAnalitic.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VentasController : ControllerBase
    {
        private readonly IVentaRepository _ventaRepository;

        public VentasController(IVentaRepository ventaRepository)
        {
            _ventaRepository = ventaRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var ventas = await _ventaRepository.GetAllAsync();
            return Ok(ventas);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Venta venta)
        {
            if (venta == null)
            {
                return BadRequest();
            }
            await _ventaRepository.AddAsync(venta);
            return Ok(venta);
        }
    }
}