using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.Controllers
{
    public class UserModel
    {
        public string myId { get; set; }

        public List<UserList1> userList;
    }
    public class UserList1
    {
        public string Email { get; set; }
        public string UserId { get; set; }
    }
}