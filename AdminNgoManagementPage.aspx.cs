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
    public partial class AdminNgoManagementPage : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataBind();
        }


        //Go Button event
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            if (checkedNgoExists())
            {
                Response.Write("<script>alert('Ngo do not exist with given username !');</script>");
            }
            else
            {
                getNgoByUsername();
            }

        }

        //Active Button event
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            updateNgoStatus("active");
        }

        // pending Button event
        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            updateNgoStatus("pending");
        }

        // deactive Button event
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            updateNgoStatus("deactive");
        }

        // delete ngo permanently
        protected void Button1_Click(object sender, EventArgs e)
        {
            deleteNgoPermanently();
        }


        // user defined method

        void getNgoByUsername()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.ngo_signup_table WHERE ngo_username = '" + TextBox1.Text.Trim() + "' ", con);



                // connected architecture

                SqlDataReader dr1 = cmd.ExecuteReader();


                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        TextBox7.Text = dr1.GetValue(0).ToString();
                        TextBox3.Text = dr1.GetValue(12).ToString();
                        TextBox2.Text = dr1.GetValue(2).ToString();
                        TextBox4.Text = dr1.GetValue(4).ToString();
                        TextBox5.Text = dr1.GetValue(3).ToString();
                        TextBox6.Text = dr1.GetValue(6).ToString();
                        TextBox8.Text = dr1.GetValue(7).ToString();
                        TextBox9.Text = dr1.GetValue(8).ToString();
                        TextBox10.Text = dr1.GetValue(5).ToString();
                        TextBox11.Text = dr1.GetValue(1).ToString();
                        TextBox12.Text = dr1.GetValue(9).ToString();

                    }


                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }


        void updateNgoStatus(string status)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE dbo.ngo_signup_table SET account_status = '" + status + "' WHERE ngo_username = '" + TextBox1.Text.Trim() + "'", con);

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


        void deleteNgoPermanently()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("DELETE from dbo.ngo_signup_table WHERE ngo_username = '" + TextBox1.Text.Trim() + "'", con);

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
            TextBox11.Text = null;
            TextBox12.Text = null;
        }


        bool checkedNgoExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM ngo_signup_table where ngo_username = '" + TextBox1.Text.Trim() + "';", con);

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