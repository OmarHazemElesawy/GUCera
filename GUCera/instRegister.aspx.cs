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
    public partial class instRegister : System.Web.UI.Page
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
            String  gend = gender.SelectedValue.ToString();
            String addr = address.Text;
            SqlCommand instReg = new SqlCommand("InstructorRegister", connection);
            instReg.CommandType = CommandType.StoredProcedure;
            instReg.Parameters.Add(new SqlParameter("@first_name", firstName));
            instReg.Parameters.Add(new SqlParameter("@last_name", lastName));
            instReg.Parameters.Add(new SqlParameter("@password", password));
            instReg.Parameters.Add(new SqlParameter("@email", email));
            instReg.Parameters.Add(new SqlParameter("@gender", gend));
            instReg.Parameters.Add(new SqlParameter("@address", addr));
            connection.Open();
            instReg.ExecuteNonQuery();
            connection.Close();
            Response.Redirect("Login.aspx");

        }
    }
}