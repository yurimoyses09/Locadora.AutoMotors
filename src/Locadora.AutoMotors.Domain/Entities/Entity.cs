using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Locadora.AutoMotors.Domain.Entities
{
    public class Entity
    {
        protected Entity()
        {
            
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("dt_criacao")]
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        [Column("dt_alteracao")]
        public DateTime DataAlteracao { get; set; }
    }
}
