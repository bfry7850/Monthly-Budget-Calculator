using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace MonthlyBudget
{
    public partial class Registration : System.Web.UI.Page
    {
        private string conStr = WebConfigurationManager.ConnectionStrings["LoginDBConnectionString1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conStr);
            SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM tblUser WHERE UserName=@UserName", con);
            check_User_Name.Parameters.AddWithValue("@UserName", txtUsername.Text);
            con.Open();

            int UserExist = (int)check_User_Name.ExecuteScalar();

            if (UserExist > 0)
            {
                //Username exist
                Response.Write("<script language='javascript'>alert('Username already exist');</script>");
                txtUsername.Text = "";
                txtPassWord.Text = "";
                txtVerify.Text = "";
                txtUsername.Focus();
                con.Close();

            }
            else
            {
                //Username doesn't exist.
                SqlCommand cmd = new SqlCommand("Insert into tblUser (username,password) values (@UserName,@PassWord)", con);
                cmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
                cmd.Parameters.AddWithValue("@PassWord", txtVerify.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                Response.Redirect("SignIn.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("SignIn.aspx");
        }
    }
}
