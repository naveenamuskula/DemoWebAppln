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
    public partial class Extract : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
            adp = new SqlDataAdapter("sp_extractdept", con);
            if (!IsPostBack)
            {
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                adp.Fill(ds, "D");
                ddldeptno.DataSource = ds.Tables["D"];
                ddldeptno.DataTextField = "DNAME";
                ddldeptno.DataValueField = "DEPTNO";
                ddldeptno.DataBind();//to bind the data to the control when the page is refreshed 
            }
        }

        protected void ddldeptno_SelectedIndexChanged(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_getdeptdetails", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@deptno", int.Parse(ddldeptno.SelectedValue));
            DataSet ds = new DataSet();
            adp.Fill(ds, "D");
            gvdata.DataSource = ds.Tables["D"];
            gvdata.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}