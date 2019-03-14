using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Profile.aspx");
            }
        }

        protected void next_Click(object sender, EventArgs e)
        {
            Session["rgstrUsr"] = inputUser.Text;
            Response.Redirect("Register2.aspx");
        }
    }
}