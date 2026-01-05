using Locadora.AutoMotors.API.DataTransferObjects;

namespace Locadora.AutoMotors.API.Mappers
{
    public static class LocadoraMapper
    {
        public static Domain.Entities.Locadora ToEntity(CreateLocacaoDTO dto) =>
                new(dto.ClienteId, dto.AutomovelId, dto.DataInicio, dto.DataFimPrevista, null, dto.ValorDiaria, dto.ValorTotal, Domain.Enums.StatusAluguel.Ativo);
    }
}
