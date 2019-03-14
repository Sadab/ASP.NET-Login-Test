using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace Login
{
    public partial class Register2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write(Session["rgstrUsr"].ToString());
            if (Session["user"] != null)
            {
                Response.Redirect("Profile.aspx");
            }
        }

        protected void register_Click(object sender, EventArgs e)
        {
            try
            {
                Session["rgstrPass"] = inputPass.Text;
                string uName = Session["rgstrUsr"].ToString().Trim();
                string pass = Session["rgstrPass"].ToString().Trim();

                SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ruhul\Documents\login.mdf; Integrated Security = True; Connect Timeout = 30");
                conn.Open();
                string query = "insert into users(username, password) values('" + uName + "','" + pass + "')";
                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();

                Response.Redirect("Blank.aspx");
            }
            catch(SqlException E)
            {
                Response.Write(E.Message);
            }

        }

        static string Encrypt(string value)
        {
            using(MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        protected void inputPass_TextChanged(object sender, EventArgs e)
        {
            inputPass.Text = Encrypt(inputPass.Text);
        }
    }

    
}