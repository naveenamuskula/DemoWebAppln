using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebAppln
{
    public partial class Cookieex1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text.Length!=0)
            {
                //create cookie variable
                //first type
                Response.Cookies["User"].Value = TextBox1.Text;
                //second type
                HttpCookie H = new HttpCookie("Username");
                H.Value = TextBox1.Text;
                Response.Cookies.Add(H);
                //expirying the cookie after  10seconds after the cookieex1 page is redirected to cookieex3 
                Response.Cookies["User"].Expires = DateTime.Now.AddSeconds(10);
                Response.Cookies["Username"].Expires = DateTime.Now.AddSeconds(30);
                Response.Redirect("Cookieex2.aspx");
            }
        }
    }
}