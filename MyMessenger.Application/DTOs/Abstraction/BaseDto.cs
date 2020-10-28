using System;
using Volo.Abp.Application.Dtos;

namespace MyMessenger.Application.DTOs.Abstraction
{
    public class BaseDtoInput
    {
    }

    public class BaseDtoOutput : EntityDto<Guid>
    {

    }
}
