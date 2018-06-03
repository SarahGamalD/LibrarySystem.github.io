using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_System_Project.Employee
{
    public partial class EmpMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    if (Request.Cookies["users"] != null)
            //    {
            //        Session.Add("user_id",Request.Cookies["users"].Values["user_id"]);
            //    }
            //    if (Session["user_id"] != null)
            //    {
            //        int user_id = int.Parse(Session["user_id"].ToString());
            //        var user = LS.Users1.SingleOrDefault(u => u.user_id == user_id);
            //        if (user == null)
            //            Response.Redirect("loginPage.aspx");
            //    }
            //    else
            //    {
            //        Response.Redirect("loginPage.aspx");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Response.Redirect("errorPage.aspx");
            //}
        }
    }
}