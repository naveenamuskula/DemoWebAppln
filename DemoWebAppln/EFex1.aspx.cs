using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebAppln
{
    public partial class EFex1 : System.Web.UI.Page
    {
        DemoEntities d = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            d = new DemoEntities();
            //Response.Write(Session["User"].ToString());
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                EMPDATA E = new EMPDATA();
                E.EMPNO = int.Parse(txtempno.Text);
                E.ENAME = txtename.Text;
                E.JOB = txtjob.Text;
                E.MGR = int.Parse(txtmgr.Text);
                E.HIREDATE = DateTime.Parse(txthiredate.Text);
                E.SAL = int.Parse(txtsal.Text);
                E.COMM = int.Parse(txtcomm.Text);
                E.DEPTNO = int.Parse(txtdeptno.Text);
                d.EMPDATAs.Add(E);
                d.SaveChanges();
            }
            catch(DbUpdateException E)
            {
                SqlException ex = E.GetBaseException() as SqlException;
                if (ex.Message.Contains("EMP_PK"))
                    lblMessage.Text = "no duplicate empno";
                else if (ex.Message.Contains("FK__EMPDATA"))
                    lblMessage.Text = "No Deptno ";
                else
                lblMessage.Text = ex.Message;
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

        protected void btninsert_Click(object sender, EventArgs e)
        {
            ObjectParameter ob = new ObjectParameter("result", typeof(string));
            d.sp_insertemp(int.Parse(txtempno.Text),
                txtename.Text,
                txtjob.Text,
                int.Parse(txtmgr.Text), 
                DateTime.Parse(txthiredate.Text), 
                int.Parse(txtsal.Text),
                int.Parse(txtcomm.Text),
                int.Parse(txtdeptno.Text),ob);
                lblMessage.Text = ob.Value.ToString();
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