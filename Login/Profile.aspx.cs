using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"] != null)
            {
                userNameDisp.Text = Session["user"].ToString();
            }
            else if(Session["user"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            
        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session.Remove("user");
            Response.Redirect("Login.aspx");
        }
    }
}