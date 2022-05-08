<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DonorSignup.aspx.cs" Inherits="OnlineMedicineDonationToNgo.UserSignup" %>

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
                     <div class="col text-center">
                        
                           <h3>Donor Signup</h3>
                        
                     </div>
                  </div>

                  <div class="row">
                     <div class="col">
                         <ul class="nav nav-tabs" id="myTab" role="tablist">
                             <li class="nav-item">
                                 <a class="nav-link active" id="donor-tab"  href="DonorSignup.aspx"  >Donor</a>
                             </li>
                             <li class="nav-item">
                                 <a class="nav-link" id="ngo-tab"  href="NgoSignup.aspx"  >NGO</a>
                             </li>   
                         </ul>
                     </div>
                  </div>

                   <br />
                
                   <div class="row">
                       <div class="col-md-4">
                           <label>Firstname</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Firstname"></asp:TextBox>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*Field cannot be empty" ControlToValidate="TextBox3" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True"></asp:RequiredFieldValidator>

                            </div>
                       </div>

                       <div class="col-md-4">
                           <label>Surname</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Surname"></asp:TextBox>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*Field cannot be empty" ControlToValidate="TextBox4" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True"></asp:RequiredFieldValidator>

                            </div>
                       </div>

                       <div class="col-md-4">
                           <label>Gender</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Gender"></asp:TextBox>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*Field cannot be empty" ControlToValidate="TextBox5" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True"></asp:RequiredFieldValidator>

                            </div>
                       </div>
                   </div>

                   <div class="row">
                       <div class="col-md-4">
                           <label>Date of Birth</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" TextMode="Date"></asp:TextBox>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="*Field cannot be empty" ControlToValidate="TextBox5" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True"></asp:RequiredFieldValidator>

                            </div>
                       </div>

                       <div class="col-md-4">
                           <label>Contact Number</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="Contact Number" TextMode="Number"></asp:TextBox>

                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*only 10 digit" ControlToValidate="TextBox7" Display="Dynamic" ForeColor="#CC3300" ValidationExpression="^[0-9]{10}$"></asp:RegularExpressionValidator>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="*Field cannot be empty" ControlToValidate="TextBox7" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True"></asp:RequiredFieldValidator>

                            </div>
                       </div>

                       <div class="col-md-4">
                           <label>Email</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="Email" TextMode="Email"></asp:TextBox>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*Field cannot be empty" ControlToValidate="TextBox8" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True"></asp:RequiredFieldValidator>

                            </div>
                       </div>
                   </div>

                   <div class="row">
                       <div class="col-md-4">
                           <label>State</label>
                            <div class="form-group">
                                <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                                    <asp:ListItem Text="Select" Value="select" />
                                    <asp:ListItem Text="Andhra Pradesh" Value="Andhra Pradesh" />
                                    <asp:ListItem Text="Arunachal Pradesh" Value="Arunachal Pradesh" />
                                    <asp:ListItem Text="Assam" Value="Assam" />
                                    <asp:ListItem Text="Bihar" Value="Bihar" />
                                    <asp:ListItem Text="Chhattisgarh" Value="Chhattisgarh" />
                                    <asp:ListItem Text="Rajasthan" Value="Rajasthan" />
                                    <asp:ListItem Text="Goa" Value="Goa" />
                                    <asp:ListItem Text="Gujarat" Value="Gujarat" />
                                    <asp:ListItem Text="Haryana" Value="Haryana" />
                                    <asp:ListItem Text="Himachal Pradesh" Value="Himachal Pradesh" />
                                    <asp:ListItem Text="Jammu and Kashmir" Value="Jammu and Kashmir" />
                                    <asp:ListItem Text="Jharkhand" Value="Jharkhand" />
                                    <asp:ListItem Text="Karnataka" Value="Karnataka" />
                                    <asp:ListItem Text="Kerala" Value="Kerala" />
                                    <asp:ListItem Text="Madhya Pradesh" Value="Madhya Pradesh" />
                                    <asp:ListItem Text="Maharashtra" Value="Maharashtra" />
                                    <asp:ListItem Text="Manipur" Value="Manipur" />
                                    <asp:ListItem Text="Meghalaya" Value="Meghalaya" />
                                    <asp:ListItem Text="Mizoram" Value="Mizoram" />
                                    <asp:ListItem Text="Nagaland" Value="Nagaland" />
                                    <asp:ListItem Text="Odisha" Value="Odisha" />
                                    <asp:ListItem Text="Punjab" Value="Punjab" />
                                    <asp:ListItem Text="Rajasthan" Value="Rajasthan" />
                                    <asp:ListItem Text="Sikkim" Value="Sikkim" />
                                    <asp:ListItem Text="Tamil Nadu" Value="Tamil Nadu" />
                                    <asp:ListItem Text="Telangana" Value="Telangana" />
                                    <asp:ListItem Text="Tripura" Value="Tripura" />
                                    <asp:ListItem Text="Uttar Pradesh" Value="Uttar Pradesh" />
                                    <asp:ListItem Text="Uttarakhand" Value="Uttarakhand" />
                                    <asp:ListItem Text="West Bengal" Value="West Bengal" />
                                </asp:DropDownList>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="*Field cannot be empty" ControlToValidate="DropDownList1" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True"></asp:RequiredFieldValidator>

                            </div>
                       </div>

                       <div class="col-md-4">
                           <label>City</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="City" ></asp:TextBox>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="*Field cannot be empty" ControlToValidate="TextBox10" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True"></asp:RequiredFieldValidator>

                            </div>
                       </div>

                       <div class="col-md-4">
                           <label>Pincode</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="Pincode" TextMode="Number"></asp:TextBox>

                                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="*only 6 digit" ControlToValidate="TextBox11" Display="Dynamic" ForeColor="#CC3300" ValidationExpression="^[0-9]{6}$"></asp:RegularExpressionValidator>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ErrorMessage="*Field cannot be empty" ControlToValidate="TextBox11" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True"></asp:RequiredFieldValidator>


                            </div>
                       </div>
                   </div>

                   <div class="row">
                       <div class="col">
                           <label>Full Address</label>
                            <div class="form-group">
                                <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Full Address" TextMode="Multiline" Rows="2"></asp:TextBox>

                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ErrorMessage="*Field cannot be empty" ControlToValidate="TextBox1" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True"></asp:RequiredFieldValidator>

                            </div>
                       </div>
                   </div>

                   <div class="row">
                       <div class="col text-center">
                            
                                <span class="badge badge-pill badge-info">Login Credentials</span>
                            
                       </div>
                   </div>

                   <div class="row">
                       <div class="col-md-6">
                           <label>Username</label>
                           <div class="form-group">
                               <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Username must be unique"></asp:TextBox>

                               <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ErrorMessage="*Field cannot be empty" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True"></asp:RequiredFieldValidator>

                           </div>
                       </div>

                       <div class="col-md-6">
                           <label>Password</label>
                           <div class="form-group">
                               <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>

                               <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="*password must be of 8 characters" ControlToValidate="TextBox9" Display="Dynamic" ForeColor="#CC3300" ValidationExpression="^[0-9A-Za-z^@#.\s]{8,15}$"></asp:RegularExpressionValidator>

                               <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ErrorMessage="*Field cannot be empty" ControlToValidate="TextBox9" Display="Dynamic" ForeColor="#CC3300" SetFocusOnError="True"></asp:RequiredFieldValidator>
                               
                           </div>
                       </div>
                   </div>

                   <div class="row">
                       <div class="col">
                           <div class="form-group">
                               <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Signup" OnClick="Button1_Click" />
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
