using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace GUCera
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StudentReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentRegister.aspx");
        }

        protected void InstReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("instRegister.aspx");
        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();
            SqlConnection connection = new SqlConnection(connString);
            int id = Int16.Parse(username.Text);
            string pass = password.Text;
            SqlCommand loginProc = new SqlCommand("userLogin",connection);
            loginProc.CommandType =  CommandType.StoredProcedure;
            loginProc.Parameters.Add(new SqlParameter("@id", id));
            loginProc.Parameters.Add(new SqlParameter("@password", pass));
            SqlParameter success = loginProc.Parameters.Add("@success",SqlDbType.Int);
            SqlParameter type = loginProc.Parameters.Add("@type", SqlDbType.Int);
            success.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;
            connection.Open();
            loginProc.ExecuteNonQuery();
            connection.Close();
            if (success.Value.ToString() == "1")
            {
                Session["User"] = id;
                if (type.Value.ToString() == "0")
                {
                    //instructor
                    Response.Redirect("instructorHome.aspx");
                }
                if (type.Value.ToString() == "1")
                {
                    //admin
                    Response.Redirect("AdminHome.aspx");
                }
                if (type.Value.ToString() == "2")
                {
                    //student
                    Response.Redirect("StudentHome.aspx");
                }
            }

        }
    }
}