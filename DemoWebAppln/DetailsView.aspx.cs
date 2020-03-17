using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoWebAppln
{
    public partial class DetailsView : System.Web.UI.Page
    {
        DemoEntities d= null;
        protected void Page_Load(object sender, EventArgs e)
        {
            Bind(); 
        }
        private void Bind()
        {
            d = new DemoEntities();
            var V = from T in d.Total1
                    select T;
            GridView.DataSource = V.ToList();
            GridView.DataBind();
            DetView.DataSource = V.ToList();
            DetView.DataBind();
            FView.DataSource = V.ToList();
            FView.DataBind();

        }

        protected void DetView_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
        {
            DetView.PageIndex = e.NewPageIndex;
            Bind();
        }
       

        protected void FView_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {
            FView.PageIndex = e.NewPageIndex;
            Bind();
            
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView.PageIndex = e.NewPageIndex;
            Bind();
        }
    }
}