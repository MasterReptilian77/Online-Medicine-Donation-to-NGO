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
    public partial class DonorProfilePage : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    Response.Write("<script>alert('Session Expired Login Again');</script>");
                    Response.Redirect("Userlogin.aspx");
                }
                else
                {


                    if (!Page.IsPostBack)
                    {
                        getDonorPersonalDetails();
                    }

                }
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Session Expired Login Again');</script>");
                Response.Redirect("Userlogin.aspx");
            }
        }


        //Update button event
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["role"] == null)
            {
                Response.Write("<script>alert('Session Expired Login Again');</script>");
                Response.Redirect("userlogin.aspx");
            }
            else
            {
                updateDonorPersonalDetails();

            }
            
        }

        void updateDonorPersonalDetails()
        {
            string password = "";
            if (TextBox13.Text.Trim() == "")
            {
                password = TextBox9.Text.Trim();
            }
            else
            {
                password = TextBox13.Text.Trim();
            }
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                SqlCommand cmd = new SqlCommand("UPDATE dbo.donor_signup_table SET firstname=@firstname, surname=@surname, gender=@gender, dob=@dob, email_id=@email_id, contact_no=@contact_no, full_address=@full_address, state=@state, city=@city, pincode=@pincode, donor_username=@donor_username, password=@password, account_status=@account_status WHERE donor_username ='" + Session["donor_username"].ToString().Trim() + "'", con);

                cmd.Parameters.AddWithValue("@firstname", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@surname", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@gender", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@dob", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@email_id", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_no", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@full_address", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@state", TextBox12.Text.Trim());
                cmd.Parameters.AddWithValue("@city", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@pincode", TextBox11.Text.Trim());
                cmd.Parameters.AddWithValue("@donor_username", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@account_status", "pending");

                int result = cmd.ExecuteNonQuery();
                con.Close();
                if (result > 0)
                {

                    Response.Write("<script>alert('Your Details Updated Successfully');</script>");
                    getDonorPersonalDetails();

                }
                else
                {
                    Response.Write("<script>alert('Invaid entry');</script>");
                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void getDonorPersonalDetails()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.donor_signup_table WHERE donor_username = '" + Session["donor_username"].ToString() + "' ", con);


                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                TextBox3.Text = dt.Rows[0]["firstname"].ToString();
                TextBox4.Text = dt.Rows[0]["surname"].ToString();
                TextBox5.Text = dt.Rows[0]["gender"].ToString();
                TextBox6.Text = dt.Rows[0]["dob"].ToString();
                TextBox8.Text = dt.Rows[0]["email_id"].ToString();
                TextBox7.Text = dt.Rows[0]["contact_no"].ToString();
                TextBox1.Text = dt.Rows[0]["full_address"].ToString();
                TextBox12.Text = dt.Rows[0]["state"].ToString();
                TextBox10.Text = dt.Rows[0]["city"].ToString();
                TextBox11.Text = dt.Rows[0]["pincode"].ToString();
                TextBox2.Text = dt.Rows[0]["donor_username"].ToString();
                TextBox9.Text = dt.Rows[0]["password"].ToString();
                

                Label1.Text = dt.Rows[0]["account_status"].ToString().Trim();

                if (dt.Rows[0]["account_status"].ToString().Trim() == "active")
                {
                    Label1.Attributes.Add("class", "badge badge-pill badge-success");
                }
                else if (dt.Rows[0]["account_status"].ToString().Trim() == "pending")
                {
                    Label1.Attributes.Add("class", "badge badge-pill badge-warning");
                }
                else if (dt.Rows[0]["account_status"].ToString().Trim() == "deactive")
                {
                    Label1.Attributes.Add("class", "badge badge-pill badge-danger");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}