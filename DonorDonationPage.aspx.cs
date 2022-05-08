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
    public partial class WebForm2 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox7.Text = DateTime.Today.ToString("dd-MM-yyyy");
            TextBox6.Text = Session["donor_firstname"].ToString();
            TextBox9.Text = Session["donor_surname"].ToString();
            TextBox8.Text = Session["donor_email_id"].ToString();
        }



        // search request id
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd2 = new SqlCommand("SELECT * FROM dbo.ngo_request_medicine_table WHERE request_id='"+TextBox11.Text.Trim()+"' ", con);

                SqlDataReader dr1 = cmd2.ExecuteReader();

                if (dr1.HasRows)
                {
                    while (dr1.Read())
                    {
                        
                        TextBox10.Text = dr1.GetValue(0).ToString();
                        TextBox2.Text = dr1.GetValue(6).ToString();
                    }                   

                }
                con.Close();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            donateNgoRequestMedicine();
        }

        void donateNgoRequestMedicine()
        {

            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }


                // change update statement to insert statement
                /*SqlCommand cmd = new SqlCommand("UPDATE dbo.donated_medicine_table SET content_name=@content_name, brand_name=@brand_name, date_of_manufactured=@date_of_manufactured, expiry_date=@expiry_date, quantity=@quantity, type_of_medicine=@type_of_medicine, donor_firstname=@donor_firstname, donor_surname=@donor_surname, donate_to=@donate_to, todays_date=@todays_date, donor_email_id=@donor_email_id, request_id=@request_id", con);*/

                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.donated_medicine_table (content_name, brand_name, date_of_manufactured, expiry_date, quantity, type_of_medicine, donor_firstname, donor_surname, donate_to, todays_date, donor_email_id, request_id) VALUES (@content_name, @brand_name, @date_of_manufactured, @expiry_date, @quantity, @type_of_medicine, @donor_firstname, @donor_surname, @donate_to, @todays_date, @donor_email_id, @request_id)",con);

                cmd.Parameters.AddWithValue("@content_name", TextBox10.Text.Trim());
                cmd.Parameters.AddWithValue("@brand_name", TextBox3.Text.Trim());
                cmd.Parameters.AddWithValue("@date_of_manufactured", TextBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@expiry_date", TextBox5.Text.Trim());
                cmd.Parameters.AddWithValue("@quantity", TextBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@type_of_medicine", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@donor_firstname", TextBox6.Text.Trim());
                cmd.Parameters.AddWithValue("@donor_surname", TextBox9.Text.Trim());
                cmd.Parameters.AddWithValue("@donate_to", TextBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@todays_date", TextBox7.Text.Trim());
                cmd.Parameters.AddWithValue("@donor_email_id", TextBox8.Text.Trim());
                cmd.Parameters.AddWithValue("@request_id", TextBox11.Text.Trim());

                int result = cmd.ExecuteNonQuery();
                
                if (result > 0)
                {

                    Response.Write("<script>alert('Thanks for your contribution');</script>");


                }

                SqlCommand cmd1 = new SqlCommand("DELETE FROM dbo.ngo_request_medicine_table WHERE request_id='"+TextBox11.Text.Trim()+"'",con);

                cmd1.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        
    }
}

// first update in donated_medicine table
// then delete in ngo_request table