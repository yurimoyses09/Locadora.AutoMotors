using Locadora.AutoMotors.Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Locadora.AutoMotors.API.DataTransferObjects
{
    public class CreateLocacaoDTO
    {
        [Required(ErrorMessage = "É necessário informar o id cliente.")]
        [JsonPropertyName("id_cliente")]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "É necessário informar o id do automovel.")]
        [JsonPropertyName("id_automovel")]
        public int AutomovelId { get; set; }

        [Required(ErrorMessage = "É necessário informar a data de inicio da locacao.")]
        [JsonPropertyName("dt_inicio")]
        public DateTimeOffset DataInicio { get; set; }

        [Required(ErrorMessage = "É necessário informar a data previst de devolução.")]
        [JsonPropertyName("dt_fim_prevista")]
        public DateTimeOffset DataFimPrevista { get; set; }

        [Required(ErrorMessage = "É necessário informar o valor da diaria.")]
        [JsonPropertyName("valor_diaria")]
        public decimal ValorDiaria { get; set; }

        [Required(ErrorMessage = "É necessário informar o valor total da locação")]
        [JsonPropertyName("valor_total")]
        public decimal? ValorTotal { get; set; }

        [Required(ErrorMessage = "É necessário informar o status.")]
        [JsonPropertyName("status")]
        public StatusAluguel Status { get; set; }
    }
}
