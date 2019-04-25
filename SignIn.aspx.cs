using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;
using System.Data;


namespace MonthlyBudget
{
    public partial class SignIn : System.Web.UI.Page
    {
        private string conStr = WebConfigurationManager.ConnectionStrings["LoginDBConnectionString1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtUserName.Focus();
            lblErrorMessage.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand cmd = new SqlCommand("Select * from tblUser where UserName='" + txtUserName.Text + "'", con);
            SqlDataReader reader;
            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if(txtPassword.Text == reader["PassWord"].ToString())
                {
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    lblErrorMessage.Visible = true;
                    txtPassword.Focus();
                }

            }
            catch (Exception er)
            {
                Response.Write("<script language='javascript'>alert('User does not exist');</script>");

            }
            finally
            {
                con.Close();

            }
        }

    }
}