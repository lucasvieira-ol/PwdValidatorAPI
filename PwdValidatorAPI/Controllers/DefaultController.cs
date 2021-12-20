using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PwdValidatorAPI.Models;

namespace PwdValidatorAPI.Controllers
{
    public class DefaultController : ApiController
    {
        [HttpPost]
        [Route("api/validatepwd")]
        public bool validatePassword(bodyRequest body)
        {
            PasswordValidator result = new PasswordValidator();

            return result.validatorResult(body.password);
        }
    }
}