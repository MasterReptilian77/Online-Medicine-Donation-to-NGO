using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineMedicineDonationToNgo
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    LinkButton1.Visible = true; // user login link
                    LinkButton2.Visible = true; // user signup link
                    LinkButton12.Visible = false; // user name link button
                    LinkButton3.Visible = false;  // user logout link

                    LinkButton6.Visible = true;  // admin login link
                    LinkButton11.Visible = false; // admin ngo management link
                    LinkButton10.Visible = false; // admin memeber management link

                    LinkButton5.Visible = false; // ngo requirement nav link
                    LinkButton4.Visible = false; // donor history nav link
                    LinkButton8.Visible = false; // put request nav link
                    LinkButton9.Visible = false; // ngo pending nav link
                    LinkButton14.Visible = false; // ngo donated medicine
                    LinkButton13.Visible = false;  // admin pending request link
                    LinkButton15.Visible = false; // admin donated medicine

                }else if (Session["role"].Equals("donor"))
                {

                    LinkButton1.Visible = false; // user login link
                    LinkButton2.Visible = false; // user signup link

                    LinkButton12.Visible = true; // user name link button
                    LinkButton12.Text = Session["donor_username"].ToString();
                    LinkButton3.Visible = true;  // user logout link

                    LinkButton6.Visible = true;  // admin login link
                    LinkButton11.Visible = false; // admin ngo management link
                    LinkButton10.Visible = false; // admin memeber management link

                    LinkButton5.Visible = true; // ngo requirement nav link
                    LinkButton4.Visible = true; // donor history nav link
                    LinkButton8.Visible = false; // put request nav link
                    LinkButton9.Visible = false; // ngo pending nav link
                    LinkButton14.Visible = false; // ngo donated medicine
                    LinkButton13.Visible = false;  // admin pending nav link    
                    LinkButton15.Visible = false; // admin donated medicine

                }
                else if (Session["role"].Equals("ngo"))
                {

                    LinkButton1.Visible = false; // user login link
                    LinkButton2.Visible = false; // user signup link

                    LinkButton12.Visible = true; // user name link button
                    LinkButton12.Text = Session["ngo_username"].ToString();
                    LinkButton3.Visible = true;  // user logout link

                    LinkButton6.Visible = true;  // admin login link
                    LinkButton11.Visible = false; // admin ngo management link
                    LinkButton10.Visible = false; // admin memeber management link

                    LinkButton5.Visible = false; // ngo requirement nav link
                    LinkButton4.Visible = false; // donor history nav link
                    LinkButton8.Visible = true; // put request nav link
                    LinkButton9.Visible = true; // ngo pending nav link
                    LinkButton14.Visible = true; // ngo donated medicine
                    LinkButton13.Visible = false;  // admin pending nav link    
                    LinkButton15.Visible = false; // admin donated medicine

                }
                else if (Session["role"].Equals("admin"))
                {
                    LinkButton1.Visible = false; // user login link
                    LinkButton2.Visible = false; // user signup link

                    LinkButton12.Visible = true; // user name link button
                    LinkButton12.Text = "Hello Admin";
                    LinkButton3.Visible = true;  // user logout link

                    LinkButton6.Visible = false;  // admin login link
                    LinkButton11.Visible = true; // admin ngo management link
                    LinkButton10.Visible = true; // admin memeber management link

                    LinkButton5.Visible = false; // ngo requirement nav link
                    LinkButton4.Visible = false; // donor history nav link
                    LinkButton8.Visible = false; // put request nav link
                    LinkButton9.Visible = false; // ngo pending nav link
                    LinkButton14.Visible = false; // ngo donated medicine
                    LinkButton13.Visible = true;  // admin pending nav link
                    LinkButton15.Visible = true; // admin donated medicine
                }
            }
            catch(Exception ex)
            {
                Response.Write("<script>alert('"+ ex.Message+"');</script>");
            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLoginPage.aspx");  
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminNgoManagementPage.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminMemberManagementPage.aspx");
        }

        protected void LinkButton13_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminPendingRequest.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("NgoPendingRequest.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            if (Session["status"].Equals("pending"))
            {
                Response.Write("<script>alert('We have detected some suspicious request, because of that your account is on hold right now !!. You cannot request medicine until we approve your account')</script>");

            }
            else
            {
                Response.Redirect("NgoRequestPage.aspx");
            }
            
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("DonorHistoryPage.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("DoNgoRequirementPage.aspx");
        }

        // logout link
        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("HomePage.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserLogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("DonorSignup.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            if (Session["role"].Equals("donor"))
            {
                Response.Redirect("DonorProfilePage.aspx");
            }
            else if (Session["role"].Equals("ngo"))
            {
                Response.Redirect("NgoProfilePage.aspx");
            }

        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void LinkButton14_Click(object sender, EventArgs e)
        {
            Response.Redirect("NgoDonationReceive.aspx");
        }

        protected void LinkButton15_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminDonationHistory.aspx");
        }
    }
}