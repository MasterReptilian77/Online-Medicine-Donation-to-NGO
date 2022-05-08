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
    public partial class UserLogin : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // user Signup button click
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DonorSignup.aspx");
        }


        // user Login button click
        protected void Button1_Click(object sender, EventArgs e)
        {
            checkingStatus();
            

        }

        void checkingStatus()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd3 = new SqlCommand("SELECT * FROM dbo.donor_signup_table WHERE donor_username = '" + TextBox1.Text.Trim() + "' AND password = '" + TextBox2.Text.Trim() + "'", con);

                SqlDataReader dr1 = cmd3.ExecuteReader();


                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        //Response.Write("<script>alert('Login Successfull')</script>");

                        
                        Session["status1"] = dr1.GetValue(12).ToString();

                    }

                    
                    if (Session["status1"].Equals("deactive"))
                    {
                        Response.Write("<script>alert('Your Account has been terminated. Connect with our Admin for more information')</script>");
                    }
                    else
                    {
                        Response.Write("<script>alert('Login Successfull')</script>");
                        loginCredentials();

                    }

                }
                else
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd4 = new SqlCommand("SELECT * FROM dbo.ngo_signup_table WHERE ngo_username = '" + TextBox1.Text.Trim() + "' AND password = '" + TextBox2.Text.Trim() + "'", con);

                    SqlDataReader dr2 = cmd4.ExecuteReader();

                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            // Response.Write("<script>alert('Login Successfull')</script>");

                            
                            Session["status2"] = dr2.GetValue(12).ToString();
                        }

                        
                        if (Session["status2"].Equals("deactive"))
                        {
                            Response.Write("<script>alert('Your Account has been terminated. Connect with our Admin for more information')</script>");
                        }
                        else
                        {
                            Response.Write("<script>alert('Login Successfull')</script>");
                            loginCredentials();

                        }
                        con.Close();
                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Credentials')</script>");
                    }
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }


            
        }

        void loginCredentials()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd1 = new SqlCommand("SELECT * FROM dbo.donor_signup_table WHERE donor_username = '" + TextBox1.Text.Trim() + "' AND password = '" + TextBox2.Text.Trim() + "'", con);



                // connected architecture

                SqlDataReader dr1 = cmd1.ExecuteReader();


                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        //Response.Write("<script>alert('Login Successfull')</script>");

                        Session["donor_username"] = dr1.GetValue(10).ToString();
                        Session["donor_firstname"] = dr1.GetValue(0).ToString();
                        Session["donor_surname"] = dr1.GetValue(1).ToString();
                        Session["donor_email_id"] = dr1.GetValue(4).ToString();
                        Session["role"] = "donor";
                        Session["status"] = dr1.GetValue(12).ToString();

                    }
                    Response.Redirect("HomePage.aspx");

                }
                else
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM dbo.ngo_signup_table WHERE ngo_username = '" + TextBox1.Text.Trim() + "' AND password = '" + TextBox2.Text.Trim() + "'", con);

                    SqlDataReader dr2 = cmd2.ExecuteReader();

                    if (dr2.HasRows)
                    {
                        while (dr2.Read())
                        {
                            // Response.Write("<script>alert('Login Successfull')</script>");

                            Session["ngo_username"] = dr2.GetValue(10).ToString();
                            Session["ngo_name"] = dr2.GetValue(0).ToString();
                            Session["role"] = "ngo";
                            Session["status"] = dr2.GetValue(12).ToString();
                        }
                        Response.Redirect("HomePage.aspx");

                    }
                    else
                    {
                        Response.Write("<script>alert('Invalid Credentials')</script>");
                    }
                }




            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}