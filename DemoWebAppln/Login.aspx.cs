using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DemoWebAppln
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_validateLogin", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@U", txtusername.Text);
            adp.SelectCommand.Parameters.AddWithValue("@P", txtpassword.Text);
            SqlParameter P = new SqlParameter("@C", SqlDbType.Int);
            P.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(P);
            DataSet ds = new DataSet();
            adp.Fill(ds, "L");
            //if username and pwd match then count of the record will be 1
            if (P.Value.ToString() == "1")
            {
                Response.Cookies["Username"].Value = txtusername.Text;
                Response.Redirect("AddEmp.aspx");

            }
            else
            {
                lblMessage.Text = "invalid credentails";
                txtusername.Text = "";
                txtusername.Focus();
            }
        }
    }
}