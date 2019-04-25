using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MonthlyBudget
{
    public partial class Housing : System.Web.UI.Page
    {
        public int Housingtotal = 0;
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
                if ((Session["val07"] != null && Session["val07"].ToString() != "") && (Session["val08"] != null && Session["val08"].ToString() != "") &&
                    (Session["val09"] != null && Session["val09"].ToString() != "") && (Session["val10"] != null && Session["val10"].ToString() != "") &&
                    (Session["val11"] != null && Session["val11"].ToString() != "") && (Session["val12"] != null && Session["val12"].ToString() != ""))
                {
                    TextBox1.Text = Session["val07"].ToString();
                    TextBox2.Text = Session["val08"].ToString();
                    TextBox3.Text = Session["val09"].ToString();
                    TextBox4.Text = Session["val10"].ToString();
                    TextBox5.Text = Session["val11"].ToString();
                    TextBox6.Text = Session["val12"].ToString();
                }
            }

            Housingtotal = 0;
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Auto.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["val07"] = TextBox1.Text;
            Session["val08"] = TextBox2.Text;
            Session["val09"] = TextBox3.Text;
            Session["val10"] = TextBox4.Text;
            Session["val11"] = TextBox5.Text;
            Session["val12"] = TextBox6.Text;

            val1 = Convert.ToInt32(TextBox1.Text);
            val2 = Convert.ToInt32(TextBox2.Text);
            val3 = Convert.ToInt32(TextBox3.Text);
            val4 = Convert.ToInt32(TextBox4.Text);
            val5 = Convert.ToInt32(TextBox5.Text);
            val6 = Convert.ToInt32(TextBox6.Text);
            Housingtotal = val1 + val2 + val3 + val4 + val5 + val6;

            Session["HT"] = Housingtotal;

            Response.Redirect("Personal.aspx");
        }
    }
}