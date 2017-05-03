using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Logger.Api.Controllers
{
    public abstract class BaseApiController : ApiController
    {
        protected IHttpActionResult GetResult<T>(T model)
        {
            if (model == null)
            {
                return this.BadRequest();
            }

            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            return this.Ok(model);
        }
    }
}