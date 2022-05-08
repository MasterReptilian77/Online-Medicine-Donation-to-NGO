using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineMedicineDonationToNgo
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] == null)
            {
                Button1.Visible = false;
                

            }else if (Session["role"].Equals("ngo"))
            {
                
                Button1.Visible = false;
                
                

            }else if (Session["role"].Equals("admin"))
            {
                Button1.Visible = false;
            }
            else if (Session["role"].Equals("donor"))
            {
                
                Button1.Visible = true;
                
                
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["status"].Equals("pending"))
            {
                Response.Write("<script>alert('We have detected some suspicious donation, because of that your account is on hold right now !!. You cannot donate until we approve your account')</script>");

            }
            else
            {
                Response.Redirect("DonorDonationPage.aspx");
            }
            
        }
    }
}