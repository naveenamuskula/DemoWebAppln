using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebAppln
{
    public partial class Update : System.Web.UI.Page
    {
        DemoEntities d = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            d = new DemoEntities();
        }

        protected void txtempno_TextChanged(object sender, EventArgs e)
        {
            int eno = int.Parse(txtempno.Text);
            var E = from E1 in d.EMPDATAs
                    where E1.EMPNO==eno
                    select E1;
            //all the rows which are converted to objs will be present in EMPDATAs
            //the o/p will be a single record bcz empno is a PK,but the system doesn't know it and assumes the o/p to be multiple records bcz C# do not have the concept of PK
            //list <EMPDATA> Lemp=E.ToList(); if query results in the O/P of mutliple records
            EMPDATA emp = E.First();//if query results in the o/p of single record
            txtename.Text = emp.ENAME;
            txtjob.Text = emp.JOB;
            txtmgr.Text = emp.MGR.ToString();
            string hd= DateTime.Parse(emp.HIREDATE.ToString()).ToString("yyyy-MM-dd");
            txthiredate.Text = hd;
            txtsal.Text = emp.SAL.ToString();
            txtcomm.Text = emp.COMM.ToString();
            txtdeptno.Text = emp.DEPTNO.ToString();

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(txtempno.Text);
            var E = from E1 in d.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            EMPDATA emp = E.First();
            int c = 0;
            bool b = int.TryParse(txtcomm.Text, out c);//to convert null to 0
            emp.ENAME=txtename.Text;
            emp.JOB = txtjob.Text;
            emp.MGR = int.Parse(txtmgr.Text);
            emp.SAL = int.Parse(txtsal.Text);
            if(c!=0)//to show null if commission is 0
            emp.COMM = c;
            emp.DEPTNO = int.Parse(txtdeptno.Text);
            d.SaveChanges();
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            int eno = int.Parse(txtempno.Text);
            var E = from E1 in d.EMPDATAs
                    where E1.EMPNO == eno
                    select E1;
            EMPDATA emp = E.First();
            d.EMPDATAs.Remove(emp);
            d.SaveChanges();
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