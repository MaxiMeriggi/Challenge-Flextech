using Challenge_Flextech.Persistence.Model;
using Challenge_Flextech.Persistence.MsSql;
using Microsoft.EntityFrameworkCore;

namespace Challenge_Flextech.Repository.MovimientosBcra
{
    public class MovimientosBcraRepository : IMovimientosBcraRepository
    {
        private readonly MsSqlContext _context;

        public MovimientosBcraRepository(MsSqlContext context)
        {
            _context = context;
        }

        public async Task<List<MovimientosBcraModel>> GetMovementsByAccount(string cuenta)
        {
            try
            {
                //Hago una llamada a la base de datos para traer la lista
                //de los movimientos de manera asincrónica.
                return await _context.movimientosBcra
                    .Where(c => c.cuentaDeudora == cuenta).ToListAsync();
            }
            catch (Exception ex)
            {
                //En caso de haber ocurrido un error, devuelvo la excepción.
                throw new Exception("Ha ocurrido un error ejecutando la solicitud", ex);
            }

            throw new NotImplementedException();
        }
    }
}
