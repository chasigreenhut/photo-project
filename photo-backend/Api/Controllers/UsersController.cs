using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Persistance ;

namespace PhotoApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class UsersController : ApiController
    { }
}
    //{
    //    [EnableCors(origins: "*", headers: "*", methods: "*")]
    //    [HttpPost]
    //    [Route("GetUser")]
    //    public void GetUser([FromBody] Users user)
    //    {
    //        //    //2
    //        //    //שמירה
    //        UserRepasitory ur = new UserRepasitory();
    //    ur.GetUser(user.userName, user.userPassword);
    //    }



//}
//}
