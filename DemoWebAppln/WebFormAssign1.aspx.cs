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
    public partial class WebFormAssign1 : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
            if (!IsPostBack)
            {
                txtstart.Enabled = false;
                txtend.Enabled = false;
                ddldeptno.Enabled = false;
                adp = new SqlDataAdapter("sp_extractdept", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();
                adp.Fill(ds, "D");
                ddldeptno.DataSource = ds.Tables["D"];
                ddldeptno.DataTextField = "DNAME";
                ddldeptno.DataValueField = "DEPTNO";
                ddldeptno.DataBind();//to bind the data to the control when the page is refreshed 
            }

        }

        protected void rdbjoiningdate_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbjoiningdate.Checked)
            {
                txtstart.Enabled = true;
                txtend.Enabled = true;
                ddldeptno.Enabled = false;
            }

        }

        protected void rdbdeptno_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbdeptno.Checked)
            {
                txtstart.Enabled = false;
                txtend.Enabled = false;
                ddldeptno.Enabled = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rdbjoiningdate.Checked)
            {
                adp = new SqlDataAdapter("sp_webjoiningdate", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@start", txtstart.Text);
                adp.SelectCommand.Parameters.AddWithValue("@end", txtend.Text);
                SqlParameter P = new SqlParameter("@cnt", SqlDbType.NVarChar, 100);
                P.Direction = ParameterDirection.Output;
                adp.SelectCommand.Parameters.Add(P);
                DataSet ds = new DataSet();
                adp.Fill(ds, "E");
                gvdata.DataSource = ds.Tables["E"];
                gvdata.DataBind();
                Label1.Text = P.Value.ToString();
           
            }
            if(rdbdeptno.Checked)
            {
                adp = new SqlDataAdapter("sp_getdeptdetails", con);
                adp.SelectCommand.CommandType = CommandType.StoredProcedure;
                adp.SelectCommand.Parameters.AddWithValue("@deptno", int.Parse(ddldeptno.SelectedValue));
                DataSet ds = new DataSet();
                adp.Fill(ds, "D");
                gvdata.DataSource = ds.Tables["D"];
                gvdata.DataBind();
                ddldeptno.Enabled = true;
            }
        }
    }
}