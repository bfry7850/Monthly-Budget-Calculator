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
    public partial class Budget : System.Web.UI.Page
    {
        public int Income = 0;
        public int Auto = 0;
        public int Housing = 0;
        public int Personal = 0;
        public int total = 0;

        private string conStr = WebConfigurationManager.ConnectionStrings["ExpensesData"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            GridView1.Visible = false;
        }
        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Income = Convert.ToInt32(Session["IT"]);
            Auto = Convert.ToInt32(Session["AT"]);
            Housing = Convert.ToInt32(Session["HT"]);
            Personal = Convert.ToInt32(Session["PT"]);

            total = (Income - (Auto + Housing + Personal));

            SqlConnection con = new SqlConnection(conStr);

            SqlCommand cmdDeleteIncome = new SqlCommand("Delete from Expenses where id=@id", con);
            cmdDeleteIncome.Parameters.AddWithValue("@id", 1);
            SqlCommand cmdDeleteAuto = new SqlCommand("Delete from Expenses where id=@id", con);
            cmdDeleteAuto.Parameters.AddWithValue("@id", 2);
            SqlCommand cmdDeleteHousing = new SqlCommand("Delete from Expenses where id=@id", con);
            cmdDeleteHousing.Parameters.AddWithValue("@id", 3);
            SqlCommand cmdDeletePersonal = new SqlCommand("Delete from Expenses where id=@id", con);
            cmdDeletePersonal.Parameters.AddWithValue("@id", 4);
            SqlCommand cmdDeleteTotal = new SqlCommand("Delete from Expenses where id=@id", con);
            cmdDeleteTotal.Parameters.AddWithValue("@id", 5);

            SqlCommand cmd1 = new SqlCommand("Insert into Expenses(id,ExpenseType,ExpenseAmount) Values(@id, @ExpenseType, @ExpenseAmount)", con);
            cmd1.Parameters.AddWithValue("@id", 1);
            cmd1.Parameters.AddWithValue("@ExpenseType", "Income");
            cmd1.Parameters.AddWithValue("@ExpenseAmount", Income);
            SqlCommand cmd2 = new SqlCommand("Insert into Expenses(id,ExpenseType,ExpenseAmount) Values(@id, @ExpenseType, @ExpenseAmount)", con);
            cmd2.Parameters.AddWithValue("@id", 2);
            cmd2.Parameters.AddWithValue("@ExpenseType", "Auto");
            cmd2.Parameters.AddWithValue("@ExpenseAmount", Auto);
            SqlCommand cmd3 = new SqlCommand("Insert into Expenses(id,ExpenseType,ExpenseAmount) Values(@id, @ExpenseType, @ExpenseAmount)", con);
            cmd3.Parameters.AddWithValue("@id", 3);
            cmd3.Parameters.AddWithValue("@ExpenseType", "Housing");
            cmd3.Parameters.AddWithValue("@ExpenseAmount", Housing);
            SqlCommand cmd4 = new SqlCommand("Insert into Expenses(id,ExpenseType,ExpenseAmount) Values(@id, @ExpenseType, @ExpenseAmount)", con);
            cmd4.Parameters.AddWithValue("@id", 4);
            cmd4.Parameters.AddWithValue("@ExpenseType", "Personal");
            cmd4.Parameters.AddWithValue("@ExpenseAmount", Personal);
            SqlCommand cmd5 = new SqlCommand("Insert into Expenses(id,ExpenseType,ExpenseAmount) Values(@id, @ExpenseType, @ExpenseAmount)", con);
            cmd5.Parameters.AddWithValue("@id", 5);
            cmd5.Parameters.AddWithValue("@ExpenseType", "Monthly Budget");
            cmd5.Parameters.AddWithValue("@ExpenseAmount", total);


            con.Open();
            cmdDeleteIncome.ExecuteNonQuery();
            cmdDeleteAuto.ExecuteNonQuery();
            cmdDeleteHousing.ExecuteNonQuery();
            cmdDeletePersonal.ExecuteNonQuery();
            cmdDeleteTotal.ExecuteNonQuery();

            cmd1.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();
            cmd5.ExecuteNonQuery();
            con.Close();

            if(total < 0)
            {
                Label1.Text = "Your spending more than you make!";
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff0000");

            }
            else
            {
                Label1.Text = "Congratulations, your doing well!";
                Label1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#22FF99");
            }

            Label1.Visible = true;
            GridView1.Visible = true;
        }
    }
}