using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        public object DT { get; private set; }

        public ActionResult Index()
        {
            UserModel AdminList = new UserModel();
            using (Models.DataClassesDataContext DT = new Models.DataClassesDataContext())
            {
                AdminList.userList = DT.UserRoleView.Select(s => new UserList1
                {
                    Email = s.Email,
                    UserId = s.UserId
                }).ToList();
                AdminList.myId = Session["userId"].ToString();
            }
            return View(AdminList);
        }
    }

}