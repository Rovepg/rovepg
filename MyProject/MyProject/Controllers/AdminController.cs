using MyProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            AdminModel AdminList = new AdminModel();
            using (DataClassesDataContext DT = new DataClassesDataContext())
            {
                AdminList.userList = DT.UserRoleView.Select(s => new UserList
                {
                    Email = s.Email,
                    RoleName = s.RoleName,
                    RoleId = s.RoleId,
                    UserId = s.UserId
                }).ToList();
                AdminList.myId = Session["userId"].ToString();
            }
            return View(AdminList);
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult saveRole(string newRoleId, string userId)
        {
            using (DataClassesDataContext DT = new DataClassesDataContext())
            {
                try
                {
                    DT.UpdateRole(userId, newRoleId);
                    return Json(0, JsonRequestBehavior.AllowGet);
                }
                catch
                {
                    return Json(-1, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult deleteUser(string userId)
        {
            using (DataClassesDataContext DT = new DataClassesDataContext())
            {
                try
                {
                    DT.DelUser(userId);
                    return Json(0, JsonRequestBehavior.AllowGet);
                }
                catch
                {
                    return Json(-1, JsonRequestBehavior.AllowGet);
                }
            }
        }
    }
}