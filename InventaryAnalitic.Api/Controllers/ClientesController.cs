using InventaryAnalitic.Domain.Entities.Csv;
using InventaryAnalitic.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace InventaryAnalitic.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly ILogger<ClientesController> _logger;

        // El repositorio es inyectado gracias a la configuración en Program.cs
        public ClientesController(IClienteRepository clienteRepository, ILogger<ClientesController> logger)
        {
            _clienteRepository = clienteRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            _logger.LogInformation("Obteniendo todos los clientes");
            var clientes = await _clienteRepository.GetAllAsync();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            _logger.LogInformation("Obteniendo cliente por ID: {Id}", id);
            var cliente = await _clienteRepository.GetByIdAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Cliente cliente)
        {
            if (cliente == null)
            {
                return BadRequest();
            }

            _logger.LogInformation("Creando nuevo cliente: {Nombre}", cliente.Nombre);
            await _clienteRepository.AddAsync(cliente);

            // Devuelve el objeto creado con su nuevo ID
            return CreatedAtAction(nameof(GetById), new { id = cliente.Id }, cliente);
        }
    }
}