using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebAppln
{
    public partial class Cookieex3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string s = Request.Cookies["User"].Value;
                string s1 = Request.Cookies["Username"].Value;
                Response.Write(s+" "+s1);
            }
            catch(NullReferenceException)
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}