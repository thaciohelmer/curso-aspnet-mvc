﻿namespace Negocio.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string CarteiraDeMotorista { get; set; }
        public int CartaoDeCredido { get; set; }
    }
}
