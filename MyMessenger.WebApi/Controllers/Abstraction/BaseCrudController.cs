using MyMessenger.Application.DTOs.Abstraction;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;

namespace MyMessenger.WebApi.Controllers.Abstraction
{
    public abstract class BaseMapController<TEntity, TDtoInput, TDtoOutput>
        : BaseController
        where TEntity : Entity
        where TDtoInput : BaseDtoInput
        where TDtoOutput : BaseDtoOutput
    {
        public TEntity MapDtoToEntity(TDtoInput dto)
        {
            return ObjectMapper.Map<TDtoInput, TEntity>(dto);
        }

        public TDtoOutput MapEntityToDto(TEntity entity)
        {
            return ObjectMapper.Map<TEntity, TDtoOutput>(entity);
        }

        public List<TEntity> MapDtoToEntity(List<TDtoInput> dtoList)
        {
            return ObjectMapper.Map<List<TDtoInput>, List<TEntity>>(dtoList);
        }

        public List<TDtoOutput> MapEntityToDto(List<TEntity> entityList)
        {
            return ObjectMapper.Map<List<TEntity>, List<TDtoOutput>>(entityList);
        }
    }
}
