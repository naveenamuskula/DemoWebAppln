using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebAppln
{
    public partial class MyMaster1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //using client side manangement variables
            //if (Request.Cookies["Username"] == null)//if cookie is not created then it has to be redirected to Login page
            // Response.Redirect("Login.aspx");//after login cookie will be created
            //else
            //Label1.Text = "Welcome " + Request.Cookies["Username"].Value;
            //using server state management variables
            if (Session["User"] == null)
            {
                Response.Redirect("Login2.aspx");
            }
            else 
              Label1.Text = "welcome" + Session["User"].ToString();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if(Request.Cookies["Username"]!=null)
            //{
            //    HttpCookie H = HttpContext.Current.Request.Cookies["Username"];
            //    H.Expires= DateTime.Now.AddSeconds(20);
            //    H.Value = " ";
            //    HttpContext.Current.Response.Cookies.Add(H);
            //    Response.Redirect("Login.aspx");
            //}
            //logout code using  session variable
            Session.Clear();
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("Login2.aspx");
        }
    }
}