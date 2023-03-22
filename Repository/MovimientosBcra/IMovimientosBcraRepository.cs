using Challenge_Flextech.Persistence.Model;

namespace Challenge_Flextech.Repository.MovimientosBcra
{
    public interface IMovimientosBcraRepository
    {
        public Task<List<MovimientosBcraModel>> GetMovementsByAccount(string cuenta);
    }
}
