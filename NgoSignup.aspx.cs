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
    public partial class NgoSignup : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkedNgoExists())
            {
                Response.Write("<script>alert('Ngo already exists with this username, try other username');</script>");
            }
            else
            {

                signUpNewNgo();
            }

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

                SqlCommand cmd = new SqlCommand("SELECT * FROM ngo_signup_table where ngo_username = '" + TextBox2.Text.Trim() + "';", con);

                // disconnected architecture
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            catch (Exception ex)
            {
                Response.Redirect("<script>alert('"+ex.Message+"');</script>");
                return false;
            }

        }


        //user defined signup method
        void signUpNewNgo()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.ngo_signup_table(ngo_name,ngo_manager_name,date_of_establishment,email_id,contact_no,full_address,state,city,pincode,license_number,ngo_username,password,account_status) VALUES (@ngo_name,@ngo_manager_name,@date_of_establishment,@email_id,@contact_no,@full_address,@state,@city,@pincode,@license_number,@ngo_username,@password,@account_status)", con);

                cmd.Parameters.AddWithValue("@ngo_name", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@ngo_manager_name", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@date_of_establishment", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@email_id", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_no", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@full_address", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@city", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@pincode", TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@license_number", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@ngo_username", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@password", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@account_status", "pending");

                cmd.ExecuteNonQuery();
                con.Close();

                Response.Write("<script> alert('Signup Successful. Go to user Login for Login');</script>");

            }
            catch (Exception ex)
            {
                Response.Write("<script> alert('" + ex.Message + "');</script>");
            }
        }
    }
}