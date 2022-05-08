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
    public partial class UserSignup : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Signup button is click event
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (checkedDonorExists())
            {
                Response.Write("<script>alert('Donor already exists with this username, try other username');</script>");
            }
            else{

                signUpNewDonor();
            }

            
        }

        

        // user defined method
        bool checkedDonorExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM donor_signup_table where donor_username = '"+ TextBox2.Text.Trim() +"';", con);

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
                


            }catch(Exception ex)
            {
                Response.Redirect("<script>alert('"+ ex.Message +"');</script>");
                return false;
            }
            
        }

        //user defined signup method
        void signUpNewDonor()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.donor_signup_table(firstname,surname,gender,dob,email_id,contact_no,full_address,state,city,pincode,donor_username,password,account_status) VALUES (@firstname,@surname,@gender,@dob,@email_id,@contact_no,@full_address,@state,@city,@pincode,@donor_username,@password,@account_status)", con);

                cmd.Parameters.AddWithValue("@firstname", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@surname", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@email_id", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_no", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@full_address", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@state", DropDownList1.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@city", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@pincode", TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@donor_username", TextBox2.Text.Trim());
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