using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if(Request.Cookies["username"] != null && Request.Cookies["password"] != null)
                {
                    user.Text = Request.Cookies["username"].Value;
                    pass.Attributes["value"] = Request.Cookies["password"].Value;
                }
            }

            if (Session["user"] != null)
            {
                Response.Redirect("Profile.aspx");
            }


            /*if(Request["LoginBtn"] != null)
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ruhul\Documents\login.mdf; Integrated Security = True; Connect Timeout = 30");
                    conn.Open();
                    string query = string.Format("Select * from users where username='" + user.Text + "' and password='" + pass.Text + "'");
                    SqlCommand command = new SqlCommand(query, conn);
                    int temp = Convert.ToInt32(command.ExecuteScalar().ToString());

                    if (temp == 1)
                    {
                        Response.Redirect("Profile.aspx");
                    }
                    conn.Close();
                } catch(Exception E)
                {
                    Response.Write(E);
                }
            }
            else if(Request["Login_Register"] != null)
            {
                Response.Redirect("Register.aspx");
            }
            else if(Request["Login_forgot"] != null)
            {
                Response.Redirect("Register2.aspx");
            }*/
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            if ((user.Text == "" || pass.Text == "") || (user.Text == "" && pass.Text == ""))
            {
                Response.Write("Fields are empty");
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ruhul\Documents\login.mdf; Integrated Security = True; Connect Timeout = 30");
                    conn.Open();
                    string query = string.Format("select count(*) from users where username='" + user.Text + "' and password='" + pass.Text + "' ");
                    SqlCommand command = new SqlCommand(query, conn);
                    string output = command.ExecuteScalar().ToString();

                    if (output == "1")
                    {
                        if (checkBox.Checked)
                        {
                            Response.Cookies["username"].Value = user.Text;
                            Response.Cookies["password"].Value = pass.Text;
                            Response.Cookies["username"].Expires = DateTime.Now.AddMinutes(1);
                            Response.Cookies["password"].Expires = DateTime.Now.AddMinutes(1);
                        }
                        else
                        {
                            Response.Cookies["username"].Expires = DateTime.Now.AddMinutes(-1);
                            Response.Cookies["password"].Expires = DateTime.Now.AddMinutes(-1);
                        }

                        Session["user"] = user.Text;
                        Response.Redirect("Profile.aspx");
                        Session.RemoveAll();
                    }
                    else
                    {
                        Response.Write("Wrong username or password");
                    }
                    conn.Close();
                }
                catch (Exception E)
                {
                    Response.Write(E);
                }
            }
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }

        protected void pass_TextChanged(object sender, EventArgs e)
        {
            pass.Text = Encrypt(pass.Text);
        }
    }
}