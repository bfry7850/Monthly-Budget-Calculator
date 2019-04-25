using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace MonthlyBudget
{
    public partial class Default : System.Web.UI.Page
    {
        public int Incometotal = 0;
        public int val1 = 0;
        public int val2 = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((Session["val01"] != null && Session["val01"].ToString() != "") && (Session["val02"] != null && Session["val02"].ToString() != ""))
                {
                    TextBox1.Text = Session["val01"].ToString();
                    TextBox2.Text = Session["val02"].ToString();

                }
            }
            Incometotal = 0;
            TextBox1.Focus();
        }

        protected void TextBox1_Click(object sender, EventArgs e)
        {
           
        }
        protected void TextBox2_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["val01"] = TextBox1.Text;
            Session["val02"] = TextBox2.Text;

            val1 = Convert.ToInt32(TextBox1.Text);
            val2 = Convert.ToInt32(TextBox2.Text);
            Incometotal = val1 + val2;

            Session["IT"] = Incometotal;

            Response.Redirect("Auto.aspx");
        }
    }
}