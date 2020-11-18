using System;
using Volo.Abp.AspNetCore.Mvc;

namespace MyMessenger.WebApi.Controllers.Abstraction
{
    public class BaseController : AbpController
    {
        public BaseController()
        {

        }

        protected Guid GetUserId()
        {
            var userId = Guid.Parse(User.Identity.Name);

            return userId;
        }
    }
}
