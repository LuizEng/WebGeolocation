using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using WebGeolocation.Models;
using Newtonsoft.Json;

namespace WebGeolocation.Controllers
{
    //[Route("api/Web")]
    public class WebController : ApiController
    {
        [HttpGet]
        [Route("User/{UserName}/Pass/{PassWord}")]
        public IHttpActionResult ValidarLogin(string UserName, string PassWord)
        {

            WebDbContext Context = new WebDbContext();

            var Query = from p in Context.Users where p.Name == UserName select p;
            if (Query.LongCount() == 0)
                return Content(HttpStatusCode.NotFound, "O usuário não possui cadastro!");
            else if (Query.Where(p => p.Password == PassWord).LongCount() == 0)
                return Content(HttpStatusCode.NoContent, "Senha incorreta!");
            else
                return Content(HttpStatusCode.OK, "Login realizado com sucesso!");
        }

        [HttpPost]
        [Route("Cadastro/{JsonConfig}")]
        public IHttpActionResult PostUsuario(string JsonConfig)
        {
            WebDbContext dbContext = new WebDbContext();
            JavaScriptSerializer Deserializer = new JavaScriptSerializer();
           
            try
            {
                dbContext.Users.Add(Deserializer.Deserialize<User>(JsonConfig));
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                return Content(HttpStatusCode.ExpectationFailed, "Ocorreu um erro ao interpretar o arquivo");
            }
            return Content(HttpStatusCode.OK, "Cadastro realizado com sucesso");
        }
    }
}
