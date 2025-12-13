using Locadora.AutoMotors.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locadora.AutoMotors.Domain.Entities
{
    [Table("tb_locadora")]
    public class Locadora : Entity
    {
        protected Locadora() { }

        [Column("id_cliente")]
        public int ClienteId { get; private set; }
        public Cliente Cliente { get; set; }

        [Column("id_automovel")]
        public int AutomovelId { get; private set; }
        public Automovel Automovel { get; set; }

        [Required]
        [Column("dt_inicio")]
        public DateTime DataInicio { get; private set; }

        [Required]
        [Column("dt_fim_prevista")]
        public DateTime DataFimPrevista { get; private set; }

        [Column("dt_fim_real")]
        public DateTime? DataFimReal { get; private set; }

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
