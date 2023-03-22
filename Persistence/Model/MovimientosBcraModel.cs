using System.ComponentModel.DataAnnotations;

namespace Challenge_Flextech.Persistence.Model
{
    public class MovimientosBcraModel
    {
        public string operatoria { get; set; }
        public string transaccion { get; set; }
        public string entidadDeudora { get; set; }
        public string cuentaDeudora { get; set; }
        public string entidadAcreedora { get; set; }
        public string cuentaAcreedora { get; set; }
        public string importe { get; set; }
        public string instruccionDePago { get; set; }
        public string fechaProcesado { get; set; }
        public string numeroInterno { get; set; }


    }
}
