using Microsoft.AspNetCore.Antiforgery;
using TestingAngular.Controllers;

namespace TestingAngular.Web.Host.Controllers
{
    public class AntiForgeryController : TestingAngularControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
