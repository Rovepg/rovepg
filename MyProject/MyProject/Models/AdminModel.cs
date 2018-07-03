using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyProject.Models
{
    public class AdminModel
    {
        public string myId { get; set; }

        public List<UserList> userList;
    }

    public class UserList
    {
        public string Email { get; set; }
        public string RoleName { get; set; }
        public string UserId { get; set; }
        public string RoleId { get; set; }
    }
}