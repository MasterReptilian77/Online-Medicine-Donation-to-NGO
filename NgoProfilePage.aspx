<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NgoProfilePage.aspx.cs" Inherits="OnlineMedicineDonationToNgo.AdminProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
      <div class="row">
         <div class="col-md-8 mx-auto">
            <div class="card">
               <div class="card-body">
                  <div class="row">
                     <div class="col text-center">
                        
                           <img width="150px" src="Imgs/userlogin.jpg"/>
                        
                     </div>
                  </div>
                  <div class="row">
                     <div class="col ">
                        <center>
                           <h4>Your Profile</h4>
                           <span>Account Status</span>
                           <asp:Label CssClass="badge badge-pill badge-info"  ID="Label1" runat="server" Text="Your status"></asp:Label>
                        </center>
                     </div>
                  </div>

                  <div class="row">
                      <div class="col">
                          <hr />
                      </div>
                  </div>

                   
                
                   <div class="row">
                       <div class="col-md-6">
                           <label>NGO Name</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Firstname" ></asp:TextBox>
                            </div>
                       </div>

                       <div class="col-md-6">
                           <label>NGO Manager Name</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Surname" ></asp:TextBox>
                            </div>
                       </div>

                       
                   </div>

                   <div class="row">
                       <div class="col-md-4">
                           <label>Date of Establishment</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Date of Establishment" ></asp:TextBox>
                            </div>
                       </div>

                       <div class="col-md-4">
                           <label>Contact Number</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="Contact Number" ></asp:TextBox>
                            </div>
                       </div>

                       <div class="col-md-4">
                           <label>Email ID</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="Email ID" ></asp:TextBox>
                            </div>
                       </div>
                   </div>

                   <div class="row">
                       <div class="col-md-4">
                           <label>State</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox12" runat="server" placeholder="State" ></asp:TextBox>
                            </div>
                       </div>

                       <div class="col-md-4">
                           <label>City</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="City" ></asp:TextBox>
                            </div>
                       </div>

                       <div class="col-md-4">
                           <label>Pincode</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="Pincode" ></asp:TextBox>
                            </div>
                       </div>
                   </div>

                   <div class="row">
                       <div class="col">
                           <label>Full Address</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Full Address" TextMode="Multiline" Rows="2" ></asp:TextBox>
                            </div>
                       </div>
                   </div>

                   <div class="row">
                       <div class="col">
                           <label>License Number</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="License Number" ReadOnly="true" ></asp:TextBox>
                            </div>
                       </div>
                   </div>

                   <div class="row">
                       <div class="col text-center">
                            
                                <span class="badge badge-pill badge-info">Login Credentials</span>
                            
                       </div>
                   </div>

                   <div class="row">
                       <div class="col-md-4">
                           <label>Username</label>
                           <div class="form-group">
                               <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Username" ReadOnly="true"></asp:TextBox>
                           </div>
                       </div>

                       <div class="col-md-4">
                           <label>Old Password</label>
                           <div class="form-group">
                               <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Old Password" ReadOnly="true"></asp:TextBox>
                           </div>
                       </div>

                       <div class="col-md-4">
                           <label>New Password</label>
                           <div class="form-group">
                               <asp:TextBox CssClass="form-control" ID="TextBox13" runat="server" placeholder="New Password"  ></asp:TextBox>
                           </div>
                       </div>
                   </div>

                   <div class="row">
                       <div class="col">
                           <div class="form-group">
                               <asp:Button class="btn btn-primary btn-block btn-lg" ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
                           </div>
                       </div>
                   </div>
                

               </div>  <!--card body end-->

            </div>  <!--card end-->
            <a href="HomePage.aspx"><< Back to Home</a><br><br>
         </div>
      </div>
   </div>
</asp:Content>
