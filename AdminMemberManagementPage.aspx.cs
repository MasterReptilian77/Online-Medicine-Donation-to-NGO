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
    public partial class AdminMemberManagementPage : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }


        // Go button event
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            if (checkedDonorExists())
            {
                Response.Write("<script>alert('Donor do not exist with given username !');</script>");
            }
            else
            {
                getDonorByUsername();
            }
            
        }

        //Active button event
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            updateDonorStatus("active");
        }


        //pending button event
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            updateDonorStatus("pending");
        }


        // deactive button event
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            updateDonorStatus("deactive");
        }

        // delete donor permanently
        protected void Button1_Click(object sender, EventArgs e)
        {
            deleteDonorPermanently();
        }


        // user defined method

        void getDonorByUsername()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.donor_signup_table WHERE donor_username = '" + TextBox1.Text.Trim() + "' ", con);



                // connected architecture

                SqlDataReader dr1 = cmd.ExecuteReader();


                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        TextBox7.Text = dr1.GetValue(0).ToString();
                        TextBox3.Text = dr1.GetValue(12).ToString();
                        TextBox2.Text = dr1.GetValue(3).ToString();
                        TextBox4.Text = dr1.GetValue(5).ToString();
                        TextBox5.Text = dr1.GetValue(4).ToString();
                        TextBox6.Text = dr1.GetValue(7).ToString();
                        TextBox8.Text = dr1.GetValue(8).ToString();
                        TextBox9.Text = dr1.GetValue(9).ToString();
                        TextBox10.Text = dr1.GetValue(6).ToString();

                    }
                    

                }
                

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }


        void updateDonorStatus(string status)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE dbo.donor_signup_table SET account_status = '" + status + "' WHERE donor_username = '"+ TextBox1.Text.Trim() +"'", con);

                cmd.ExecuteNonQuery();
                TextBox3.Text = status;
                GridView1.DataBind();
                con.Close();

                
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }


        void deleteDonorPermanently()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from dbo.donor_signup_table WHERE donor_username = '" + TextBox1.Text.Trim() + "'", con);

                cmd.ExecuteNonQuery();
                GridView1.DataBind();
                con.Close();
                clearForm();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void clearForm()
        {
            TextBox1.Text = null;
            TextBox7.Text = null;
            TextBox3.Text = null;
            TextBox2.Text = null;
            TextBox4.Text = null;
            TextBox5.Text = null;
            TextBox6.Text = null;
            TextBox8.Text = null;
            TextBox9.Text = null;
            TextBox10.Text = null;
        }


        bool checkedDonorExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM donor_signup_table where donor_username = '" + TextBox1.Text.Trim() + "';", con);

                // disconnected architecture
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return false;
                }
                else
                {
                    return true;
                }



            }
            catch (Exception ex)
            {
                Response.Redirect("<script>alert('" + ex.Message + "');</script>");
                return true;
            }

        }
    }

}