using System;
using Volo.Abp.AspNetCore.Mvc;

namespace MyMessenger.WebApi.Controllers.Abstraction
{
    public class BaseController : AbpController
    {
        public BaseController()
        {

        }

        /// <summary>
        /// TODO: get userId from claims
        /// </summary>
        protected Guid GetUserId()
        {
            // seed value
            return new Guid("00000000-0000-0000-0000-000000000001");
        }
    }
}
