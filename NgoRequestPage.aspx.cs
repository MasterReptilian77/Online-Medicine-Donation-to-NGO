using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineMedicineDonationToNgo
{
    public partial class NgoRequestPage : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            placeNgoRequestPage();
        }

        //Generate Request id
        protected void Button2_Click(object sender, EventArgs e)
        {
            int len = 10;
            const string ValidChar = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*)(";
            StringBuilder result = new StringBuilder();

            Random rand = new Random();
            while (0 < len--)
            {
                result.Append(ValidChar[rand.Next(ValidChar.Length)]);
            }
            TextBox7.Text = result.ToString();
        }
        void placeNgoRequestPage()
        {
            
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd1 = new SqlCommand("SELECT * FROM dbo.ngo_request_medicine_table WHERE request_id='"+TextBox7.Text.Trim()+"'",con);

                int result = cmd1.ExecuteNonQuery();
                if (result > 0)
                {
                    Response.Write("<script>alert('Request Id is already assigned please change');</script>");
                }
                else
                {
                    // change update statement to insert statement
                    /*SqlCommand cmd = new SqlCommand("UPDATE dbo.ngo_request_medicine_table SET content_name=@content_name, quantity=@quantity, issue_date=@issue_date, expiry_date=@expiry_date, location=@location, type_of_medicine=@type_of_medicine, ngo_name=@ngo_name, ngo_email_id=@ngo_email_id, request_id=@request_id", con);*/

                    SqlCommand cmd = new SqlCommand("INSERT INTO dbo.ngo_request_medicine_table (content_name, quantity, issue_date, expiry_date, location, type_of_medicine, ngo_name, ngo_email_id, request_id) VALUES (@content_name, @quantity, @issue_date, @expiry_date, @location, @type_of_medicine, @ngo_name, @ngo_email_id, @request_id)", con);

                    cmd.Parameters.AddWithValue("@content_name", TextBox10.Text.Trim());
                    cmd.Parameters.AddWithValue("@quantity", TextBox3.Text.Trim());
                    cmd.Parameters.AddWithValue("@issue_date", TextBox4.Text.Trim());
                    cmd.Parameters.AddWithValue("@expiry_date", TextBox5.Text.Trim());
                    cmd.Parameters.AddWithValue("@location", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@type_of_medicine", DropDownList1.SelectedItem.Value);
                    cmd.Parameters.AddWithValue("@ngo_name", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@ngo_email_id", TextBox6.Text.Trim());
                    cmd.Parameters.AddWithValue("@request_id", TextBox7.Text.Trim());

                    int res = cmd.ExecuteNonQuery();
                    con.Close();
                    if (res > 0)
                    {
                        Response.Write("<script>alert('Request has been placed !!');</script>");

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