
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalSafety
{
    public partial class safety : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList1.DataBind();
        }
        protected void New_Click(object sender, EventArgs e)
        {

            SqlDataSource1.InsertParameters["location_id"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tlocid")).Text;
            SqlDataSource1.InsertParameters["year"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tyear")).Text;
            SqlDataSource1.InsertParameters["month"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tmonth")).Text;
            SqlDataSource1.InsertParameters["Shop_Strength"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tshopstr")).Text;
            SqlDataSource1.InsertParameters["Office_Strength"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Toffstr")).Text;
            SqlDataSource1.InsertParameters["strength"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tstr")).Text;
            SqlDataSource1.InsertParameters["accidents"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tacc")).Text;
            SqlDataSource1.InsertParameters["fatal"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tfatal")).Text;
            SqlDataSource1.InsertParameters["mandayslost"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tml")).Text;
            SqlDataSource1.InsertParameters["frequency"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tfreq")).Text;
            SqlDataSource1.InsertParameters["severityrate"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Tsevrate")).Text;
            SqlDataSource1.InsertParameters["hefr"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Thefr")).Text;
            SqlDataSource1.InsertParameters["hesr"].DefaultValue = ((TextBox)GridView1.FooterRow.FindControl("Thesr")).Text;
            SqlDataSource1.Insert();
            GridView1.ShowFooter = false;
            DropDownList1.DataBind();

        }
        


        protected void insert_click(object sender, EventArgs e)
        {
            GridView1.ShowFooter = true;
        }

        protected void Undo_Click(object sender, EventArgs e)
        {
            GridView1.ShowFooter = false;
        }
      
    }  
}
