using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication7.Controllers
{
    public class CommentsController : ApiController
    {
        // GET: api/Comments
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Comments/5
        public object Get(int id)
        {            
            int pageindex = int.Parse(System.Web.HttpContext.Current.Request["pageindex"]);

            var infos = Comments.GetComments().OrderByDescending(a=>a.add_time).Where(a => a.belongId == id).Skip((pageindex - 1) * 10).Take(10);
            return Json(new { status = 0, message = infos });
        }

        // POST: api/Comments
        public void Post([FromBody]Comments value)
        {
            value.add_time = DateTime.Now;
            Comments.AddComments(value);

        }

        // PUT: api/Comments/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Comments/5
        public void Delete(int id)
        {
        }
    }
}
