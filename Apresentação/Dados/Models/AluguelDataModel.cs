using System;

namespace Dados.Models
{
    public class AluguelDataModel
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int CarroId { get; set; }
        public DateTime DataTransacao { get; set; }
        public DateTime DataReserva { get; set; }
        public Boolean Efetivado { get; set; }
    }
}
