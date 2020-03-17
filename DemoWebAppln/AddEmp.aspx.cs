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
    public partial class AddEmp : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_insertemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno",int.Parse(txtempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@ename", txtename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@job", txtjob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@mgr", int.Parse(txtmgr.Text));
            adp.SelectCommand.Parameters.AddWithValue("@hd", DateTime.Parse(txthiredate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@sal", int.Parse(txtsal.Text));
            adp.SelectCommand.Parameters.AddWithValue("@comm", int.Parse(txtcomm.Text));
            adp.SelectCommand.Parameters.AddWithValue("@deptno", int.Parse(txtdeptno.Text));
            SqlParameter P = new SqlParameter("@result", SqlDbType.NVarChar,200);
            P.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(P);
            DataSet ds = new DataSet();
            adp.Fill(ds, "E");
            lblMessage.Text = P.Value.ToString();
            clear();
        }
        public void clear()
        {
            txtempno.Text = "";
            txtename.Text = "";
            txtjob.Text = "";
            txtmgr.Text = "";
            txthiredate.Text = "";
            txtsal.Text = "";
            txtcomm.Text = "";
            txtdeptno.Text = "";
        }
    }
    

}