using Challenge_Flextech.Repository.MovimientosBcra;
using Microsoft.AspNetCore.Mvc;

namespace Challenge_Flextech.Controllers.movimientosBcra
{
    [Route("[controller]")]
    [ApiController]
    public class BcraController : ControllerBase
    {
        private readonly IMovimientosBcraRepository _movimientosBcraRepository;

        public BcraController(IMovimientosBcraRepository movimientosBcraRepository)
        {
            _movimientosBcraRepository = movimientosBcraRepository;
        }

        /// <summary>
        /// Realiza una solicitud a la base de datos para traer un listado de los movimientos en base a una cuenta.
        /// </summary>
        /// <param name="cuenta">String determinando qué cuenta va a solicitar los datos.</param>
        /// <returns>Devuelve una lista de movimientos en formato Json.</returns>
        [HttpGet("/bcra/movimientos/{cuenta}/credito")]
        public async Task<ActionResult> GetMovementsByAccount(string cuenta)
        {
            try
            {
                //Envio la solicitud al repositorio para devolver el listado de movimientos
                // y devuelvo la misma en un objeto como Json.
                return Ok(await _movimientosBcraRepository.GetMovementsByAccount(cuenta));
            }catch(Exception ex)
            {
                //En caso de haber una excepción, se devuelve el estado 500 junto a su mensaje.
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
