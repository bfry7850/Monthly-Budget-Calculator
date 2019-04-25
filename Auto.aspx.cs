using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonthlyBudget
{
    public partial class Auto : System.Web.UI.Page
    {
        public int Autototal =  0;
        public int val1 = 0;
        public int val2 = 0;
        public int val3 = 0;
        public int val4 = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((Session["val03"] != null && Session["val03"].ToString() != "") && (Session["val04"] != null && Session["val04"].ToString() != "") && 
                    (Session["val05"] != null && Session["val05"].ToString() != "") && (Session["val06"] != null && Session["val06"].ToString() != ""))
                {
                    TextBox1.Text = Session["val03"].ToString();
                    TextBox2.Text = Session["val04"].ToString();
                    TextBox3.Text = Session["val05"].ToString();
                    TextBox4.Text = Session["val06"].ToString();
                }
            }
            Autototal = 0;
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["val03"] = TextBox1.Text;
            Session["val04"] = TextBox2.Text;
            Session["val05"] = TextBox3.Text;
            Session["val06"] = TextBox4.Text;

            val1 = Convert.ToInt32(TextBox1.Text);
            val2 = Convert.ToInt32(TextBox2.Text);
            val3 = Convert.ToInt32(TextBox3.Text);
            val4 = Convert.ToInt32(TextBox4.Text);
            Autototal = val1 + val2 + val3 + val4;

            Session["AT"] = Autototal;

            Response.Redirect("Housing.aspx");
        }
    }
}