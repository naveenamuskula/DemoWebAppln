using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebAppln
{
    public partial class StateMngmtViewstate : System.Web.UI.Page
    {
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ViewState["V"] == null)
                ViewState["V"] = 10;
            else
                ViewState["V"] = (int)ViewState["V"] + 1;

            if (i != 0)
                i = 10;
            else
                i = i + 1;
            TextBox1.Text = (i).ToString();
            TextBox2.Text = ViewState["V"].ToString();
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewStateex2.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}