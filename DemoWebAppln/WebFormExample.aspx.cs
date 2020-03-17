using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace DemoWebAppln
{
    public partial class WebFormExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Response.Write("<script>alert('Postback');</script>");
            }
            else
                Response.Write("<script>alert('Not Postback');</script>");


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void InitializeComponent()
        {
            this.LoadComplete += new System.EventHandler(this.Page_LoadComplete);
            this.PreInit += new System.EventHandler(this.Page_PreInit);
            this.PreLoad += new System.EventHandler(this.Page_PreLoad);
            this.PreRenderComplete += new System.EventHandler(this.Page_PreRenderComplete);
            this.InitComplete += new System.EventHandler(this.Page_InitComplete);
            this.SaveStateComplete += new System.EventHandler(this.Page_SaveStateComplete);
            this.Init += new System.EventHandler(this.Page_Init);
            this.Load += new System.EventHandler(this.Page_Load);
            this.PreRender += new System.EventHandler(this.Page_PreRender);
            this.Unload += new System.EventHandler(this.Page_Unload);

        }

        private void Page_Init(object sender, EventArgs e)
        {

        }

        

        private void Page_LoadComplete(object sender, EventArgs e)
        {

        }

        private void Page_PreInit(object sender, EventArgs e)
        {

        }

        private void Page_PreLoad(object sender, EventArgs e)
        {

        }

        private void Page_InitComplete(object sender, EventArgs e)
        {

        }

        private void Page_PreRender(object sender, EventArgs e)
        {

        }

        private void Page_PreRenderComplete(object sender, EventArgs e)
        {

        }

        private void Page_SaveStateComplete(object sender, EventArgs e)
        {

        }

        private void Page_Unload(object sender, EventArgs e)
        {

        }
    }
}