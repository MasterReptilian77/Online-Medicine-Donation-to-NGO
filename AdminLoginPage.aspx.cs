using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineMedicineDonationToNgo
{
    public partial class AdminLoginPage : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Admin Login button event
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.admin_login_table WHERE admin_username = '" + TextBox1.Text.Trim() + "' AND password = '" + TextBox2.Text.Trim() + "'", con);



                // connected architecture

                SqlDataReader dr1 = cmd.ExecuteReader();


                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        Response.Write("<script>alert('Login Successfull');</script>");

                        Session["admin_username"] = dr1.GetValue(1).ToString();
                        Session["admin_name"] = dr1.GetValue(0).ToString();
                        Session["role"] = "admin";
                        //Session["status"] = dr1.GetValue(12).ToString();
                    }
                    Response.Redirect("HomePage.aspx");

                }
                else
                {
                    Response.Write("<script>alert('Invalid Credentials');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        
    }
}