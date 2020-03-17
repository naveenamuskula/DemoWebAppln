using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebAppln
{
    public partial class SSMConfirm : System.Web.UI.Page
    {
        SqlConnection con = null;
        SqlDataAdapter adp = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ToString());
            if (Session["E"] != null)
            {
                EMPDATA E = (EMPDATA)Session["E"];
                lblempno.Text = E.EMPNO.ToString();
                lblename.Text = E.ENAME;
                lbljob.Text = E.JOB;
                lblmgr.Text = E.MGR.ToString();
                lblhiredate.Text = E.HIREDATE.ToString();
                lblsal.Text = E.SAL.ToString();
                lblcomm.Text = E.COMM.ToString();
                lbldeptno.Text = E.DEPTNO.ToString();
                //after displaying the details  that we have entered in the labels,there is no further use of session variables and we are removing those session variables 
               // Session.Remove("E");
            }
            else
                Response.Redirect("SSMex2.aspx");
           
        }

        protected void btnconfirm_Click(object sender, EventArgs e)
        {
            adp = new SqlDataAdapter("sp_insertemp", con);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand.Parameters.AddWithValue("@eno", int.Parse(lblempno.Text));
            adp.SelectCommand.Parameters.AddWithValue("@ename", lblename.Text);
            adp.SelectCommand.Parameters.AddWithValue("@job", lbljob.Text);
            adp.SelectCommand.Parameters.AddWithValue("@mgr", int.Parse(lblmgr.Text));
            adp.SelectCommand.Parameters.AddWithValue("@hd", DateTime.Parse(lblhiredate.Text));
            adp.SelectCommand.Parameters.AddWithValue("@sal", int.Parse(lblsal.Text));
            adp.SelectCommand.Parameters.AddWithValue("@comm", int.Parse(lblcomm.Text));
            adp.SelectCommand.Parameters.AddWithValue("@deptno", int.Parse(lbldeptno.Text));
            SqlParameter P = new SqlParameter("@result", SqlDbType.NVarChar, 200);
            P.Direction = ParameterDirection.Output;
            adp.SelectCommand.Parameters.Add(P);
            DataSet ds = new DataSet();
            adp.Fill(ds, "Q");
            Label1.Text = P.Value.ToString();
            Session.Remove("E");
        }
    }
}