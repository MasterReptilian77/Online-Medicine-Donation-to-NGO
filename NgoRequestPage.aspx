<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NgoRequestPage.aspx.cs" Inherits="OnlineMedicineDonationToNgo.NgoRequestPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <div class="container">
      <div class="row">
         <div class="col-md-7 mx-auto">
            <div class="card">
               <div class="card-body">

                  <div class="row">
                     <div class="col">
                        <h4>Fill Medicine details</h4>
                        <hr />
                     </div>
                  </div>

                  <div class="row">
                     <div class="col-md-6">
                        <label>Content Name</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Content Name" ></asp:TextBox>
                        </div>
                     </div>

                      <div class="col-md-6">
                        <label>Quantity</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Quantity" TextMode="Number"></asp:TextBox>
                        </div>
                      </div>

                  </div>

                  
                  <div class="row">

                      <div class="col-md-6">
                        <label>Issue Date</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" TextMode="Date"></asp:TextBox>
                        </div>
                      </div>

                      <div class="col-md-6">
                        <label>Expiry Date</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" TextMode="Date"></asp:TextBox>
                        </div>
                      </div>
 
                  </div>

                  <div class="row">

                      <div class="col-md-6">
                        <label>Location</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Location"></asp:TextBox>
                        </div>
                      </div>

                      <div class="col-md-6">
                        <label>Type of Medicine</label>
                        <div class="form-group">
                            <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                                <asp:ListItem Text="Select" Value="Select" />
                                <asp:ListItem Text="Syrup" Value="Syrup" />
                                <asp:ListItem Text="Tablet" Value="Tablet" />
                                <asp:ListItem Text="Capsule" Value="Capsule" />
                            </asp:DropDownList>
                        </div>
                      </div>
 
                  </div>

                  <div class="row">
                      <div class="col">
                          <label>NGO Name</label>
                          <div class="form-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="NGO Name"></asp:TextBox>
                          </div>
                      </div>
                  </div>

                  <div class="row">
                      <div class="col-md-6">
                          <label>NGO Email ID</label>
                          <div class="form-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Email Id"></asp:TextBox>
                          </div>
                      </div>
                      <div class="col-md-6">
                          <label>Request ID</label>
                          <div class="form-group">
                              <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="Unique request id" ReadOnly="true" ></asp:TextBox>
                          </div>
                          <div class="form-group">
                               <asp:Button class="btn btn-success btn-block" ID="Button2" runat="server" Text="Generate Id" OnClick="Button2_Click" />
                          </div>
                      </div>
                  </div>
                  
                  <br />
                  <div class="row">
                       <div class="col">
                           <div class="form-group">
                               <asp:Button class="btn btn-primary btn-block btn-lg" ID="Button1" runat="server" Text="Request" OnClick="Button1_Click" />
                           </div>
                       </div>
                   </div>
                  

               </div>  <!--card body-->
            </div>       <!--card-->
            <a href="HomePage.aspx"><< Back to Home</a><br><br>
            <br />
         </div>
      </div>
   </div>
</asp:Content>
