using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebAppln
{
    public partial class Validators : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            DateTime today = DateTime.Today;
            DateTime dob = DateTime.Parse(txtdob.Text);
            int age=(int)(today.Subtract(dob).TotalDays) / 365;
            if (age >= 21 && age <= 58)
                args.IsValid = true;
            else
            args.IsValid = false;
        }
    }
}