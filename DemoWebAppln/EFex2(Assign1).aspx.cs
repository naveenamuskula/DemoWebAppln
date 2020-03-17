using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebAppln
{
    public partial class EFex2_Assign1_ : System.Web.UI.Page
    {
        DemoEntities d = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            d = new DemoEntities();
            if (!IsPostBack)
            {
                txtstart.Enabled = false;
                txtend.Enabled = false;
                ddldeptno.Enabled = false;
            }
            if(!IsPostBack)
            { 
                var D = from D1 in d.DEPTDATAs
                        select D1;
                ddldeptno.DataValueField = "Deptno";
                ddldeptno.DataTextField = "Dname";
                ddldeptno.DataSource = D.ToList();
                DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (rdbjoiningdate.Checked)
            {
                DateTime start = DateTime.Parse(txtstart.Text);
                DateTime end = DateTime.Parse(txtend.Text);
                var E=from E1  in d.EMPDATAs
                      where E1.HIREDATE>=start && E1.HIREDATE<=end
                       select E1;
                List<EMPDATA> Lemp = E.ToList();
                gvdata.DataSource = Lemp;
                gvdata.DataBind();
                if (gvdata.Rows.Count == 0)
                    Label1.Text = "NO RECORDS FOUND";
                    
            }
            if(rdbdeptno.Checked)
            {
                int dno = int.Parse(ddldeptno.SelectedValue);
                var D = from D1 in d.EMPDATAs
                        where D1.DEPTNO == dno
                        select D1;
                List<EMPDATA> Ldept = D.ToList();
                gvdata.DataSource = Ldept;
                gvdata.DataBind();
                if (gvdata.Rows.Count == 0)
                    Label1.Text = "NO RECORDS FOUND";

            }

        }

        
        

        protected void rdbjoiningdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbjoiningdate.Checked)
            {
                txtstart.Enabled = true;
                txtend.Enabled = true;
                ddldeptno.Enabled = false;
            }

        }

        protected void rdbdeptno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbdeptno.Checked)
            {
                txtstart.Enabled = false;
                txtend.Enabled = false;
                ddldeptno.Enabled = true;
            }
        }
    }
}