using ShoeStore.ProductsApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace ShoeStore.ProductsApi.Controllers
{
    [RoutePrefix("api/Authenticate")]
    public class AuthenticateController : ApiController
    {        
        [HttpPost]
        [Route("AuthCookie")]
        [AllowAnonymous]
        public HttpResponseMessage AuthCookie(AuthCookieModel authCookie)
        {
            var resp = new HttpResponseMessage();

            var cookie = new CookieHeaderValue(".ASPXAUTH", authCookie.Value);            
            cookie.Domain = Request.RequestUri.Host;
            cookie.Path = "/";

            resp.Headers.AddCookies(new CookieHeaderValue[] { cookie });
            return resp;
        }

    }
}
