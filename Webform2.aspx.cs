using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace safety
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void add_Click(object sender, EventArgs e)
        {
           
            SqlDataSource1.InsertParameters["Year"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Textyear")).Text;
            SqlDataSource1.Insert();
            GridView1.ShowFooter = false;
        }
        protected void new_click(object sender, EventArgs e)
        {
            GridView1.ShowFooter = true;
        }
        protected void bck_click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
        protected void cancel_click(object sender, EventArgs e)
        {
            GridView1.ShowFooter = false;
        }
    }
}
