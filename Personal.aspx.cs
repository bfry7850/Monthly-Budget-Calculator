using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonthlyBudget
{
    public partial class Personal : System.Web.UI.Page
    {
        public int Personaltotal = 0;
        public int val1 = 0;
        public int val2 = 0;
        public int val3 = 0;
        public int val4 = 0;
        public int val5 = 0;
        public int val6 = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if ((Session["val13"] != null && Session["val13"].ToString() != "") && (Session["val14"] != null && Session["val14"].ToString() != "") &&
                    (Session["val15"] != null && Session["val15"].ToString() != "") && (Session["val16"] != null && Session["val16"].ToString() != "") &&
                    (Session["val17"] != null && Session["val17"].ToString() != "") && (Session["val18"] != null && Session["val18"].ToString() != ""))
                {
                    TextBox1.Text = Session["val13"].ToString();
                    TextBox2.Text = Session["val14"].ToString();
                    TextBox3.Text = Session["val15"].ToString();
                    TextBox4.Text = Session["val16"].ToString();
                    TextBox5.Text = Session["val17"].ToString();
                    TextBox6.Text = Session["val18"].ToString();
                }
            }

            Personaltotal = 0;
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Housing.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["val13"] = TextBox1.Text;
            Session["val14"] = TextBox2.Text;
            Session["val15"] = TextBox3.Text;
            Session["val16"] = TextBox4.Text;
            Session["val17"] = TextBox5.Text;
            Session["val18"] = TextBox6.Text;

            val1 = Convert.ToInt32(TextBox1.Text);
            val2 = Convert.ToInt32(TextBox2.Text);
            val3 = Convert.ToInt32(TextBox3.Text);
            val4 = Convert.ToInt32(TextBox4.Text);
            val5 = Convert.ToInt32(TextBox5.Text);
            val6 = Convert.ToInt32(TextBox6.Text);
            Personaltotal = val1 + val2 + val3 + val4 + val5 + val6;

            Session["PT"] = Personaltotal;

            Response.Redirect("Budget.aspx");
        }
    }
}