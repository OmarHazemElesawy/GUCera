using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class studentRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void reg_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection connection = new SqlConnection(connString);
            String firstName = fname.Text;
            String lastName = lname.Text;
            String password = pass.Text;
            String email = mail.Text;
            String gend = gender.SelectedValue.ToString();
            String addr = address.Text;
            SqlCommand studentReg = new SqlCommand("studentRegister", connection);
            studentReg.CommandType = CommandType.StoredProcedure;
            studentReg.Parameters.Add(new SqlParameter("@first_name", firstName));
            studentReg.Parameters.Add(new SqlParameter("@last_name", lastName));
            studentReg.Parameters.Add(new SqlParameter("@password", password));
            studentReg.Parameters.Add(new SqlParameter("@email", email));
            studentReg.Parameters.Add(new SqlParameter("@gender", gend));
            studentReg.Parameters.Add(new SqlParameter("@address", addr));
            connection.Open();
            studentReg.ExecuteNonQuery();
            connection.Close();
            Response.Redirect("Login.aspx");

        }
    }
}