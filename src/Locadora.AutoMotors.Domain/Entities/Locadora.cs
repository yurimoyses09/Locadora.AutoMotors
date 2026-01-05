using Locadora.AutoMotors.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locadora.AutoMotors.Domain.Entities
{
    [Table("tb_locadora")]
    public class Locadora : Entity
    {
        protected Locadora() { }

        public Locadora(int clienteId, int automovelId, DateTimeOffset dataInicio, DateTimeOffset dataFimPrevista, DateTimeOffset? dataFimReal, decimal valorDiaria, decimal? valorTotal, StatusAluguel status)
        {
            ClienteId = clienteId;
            AutomovelId = automovelId;
            DataInicio = dataInicio;
            DataFimPrevista = dataFimPrevista;
            DataFimReal = dataFimReal;
            ValorDiaria = valorDiaria;
            ValorTotal = valorTotal;
            Status = status;
        }

        [Column("id_cliente")]
        [Required]
        public int ClienteId { get; private set; }
        public Cliente Cliente { get; set; }

        [Column("id_automovel")]
        [Required]
        public int AutomovelId { get; private set; }
        public Automovel Automovel { get; set; }

        [Required]
        [Column("dt_inicio")]
        public DateTimeOffset DataInicio { get; private set; }

        [Required]
        [Column("dt_fim_prevista")]
        public DateTimeOffset DataFimPrevista { get; private set; }

        [Column("dt_fim_real")]
        public DateTimeOffset? DataFimReal { get; private set; }

        [Required]
        [Column("valor_diaria")]
        public decimal ValorDiaria { get; private set; }

        [Required]
        [Column("valor_total")]
        public decimal? ValorTotal { get; private set; }

        [Required]
        [Column("status_aluguel")]
        public StatusAluguel Status { get; private set; }
    }
}
