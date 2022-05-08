<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminNgoManagementPage.aspx.cs" Inherits="OnlineMedicineDonationToNgo.AdminNgoManagementPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    
    <div class="container-fluid">
        <div class="row">

            <div class="col-md-5">

                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col text-center">
                                <h4>NGO Details</h4>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col text-center">
                                <img width="150px" src="Imgs/userlogin.jpg"/>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col ">
                                <hr />
                            </div>
                        </div>

                        <div class="row">

                            <div class="col-md-3">
                                <label>Username</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox CssClass="form-control mr-1" ID="TextBox1" runat="server" placeholder="Username"></asp:TextBox>
                                        <asp:LinkButton ToolTip="search" CssClass="btn btn-primary mr-1"  ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Go</asp:LinkButton>
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>NGO Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="NGO Name" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-5">
                                <label>Account Status</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox  CssClass="form-control mr-1" ID="TextBox3" runat="server" placeholder="Status" ReadOnly="true"></asp:TextBox>
                                        <asp:LinkButton ToolTip="active" CssClass="btn btn-success mr-1"  ID="LinkButton1" runat="server" OnClick="LinkButton1_Click"><i class="fas fa-check-circle"></i></asp:LinkButton>
                                        <asp:LinkButton ToolTip="pending" CssClass="btn btn-warning mr-1"  ID="LinkButton2" runat="server" OnClick="LinkButton2_Click"><i class="fas fa-pause-circle"></i></asp:LinkButton>
                                        <asp:LinkButton ToolTip="deactive" CssClass="btn btn-danger mr-1"  ID="LinkButton3" runat="server" OnClick="LinkButton3_Click"><i class="fas fa-times-circle"></i></asp:LinkButton>
                                    </div>
                                </div>
                            </div>

                        </div>

                        <div class="row">

                            <div class="col-md-4">
                                <label>Date of Establishment</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Date of Establishment" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Contact No</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Contact No" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Email ID</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Email ID" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            
                            <div class="col-md-4">
                                <label>State</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="State" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>City</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="City" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Pincode</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox9" runat="server" placeholder="Pincode" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>

                        </div>

                        <div class="row">

                            <div class="col">
                                <label>Full Address</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Full Address" ReadOnly="true" TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </div>
                            </div>

                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label>NGO Manager Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="NGO Manager Name" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <label>NGO License Number</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox12" runat="server" placeholder="NGO License Number" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                            
                        </div>

                        <div class="row">

                            <div class="col mx-auto">
                                <asp:Button CssClass="btn btn-lg btn-block btn-danger" ID="Button1" runat="server" Text="Delete NGO Permanently" OnClick="Button1_Click" />
                            </div>

                        </div>

                    </div>
                </div>

            </div>

            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        
                        <div class="row">
                            <div class="col text-center">
                                <h4>NGO List</h4>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>

                        <div class="row">
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineMedicineDonationToNgoConnectionString %>" SelectCommand="SELECT * FROM [ngo_signup_table]"></asp:SqlDataSource>
                            <div class="col">
                                <asp:GridView CssClass="table thead-striped table-bordered"  ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ngo_username" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="ngo_username" HeaderText="Username" ReadOnly="True" SortExpression="ngo_username" />
                                        <asp:BoundField DataField="account_status" HeaderText="Account Status" SortExpression="account_status" />
                                        <asp:BoundField DataField="ngo_name" HeaderText="Name" SortExpression="ngo_name" />
                                        <asp:BoundField DataField="state" HeaderText="State" SortExpression="state" />
                                        
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>

                    </div>
                </div>
            </div>

        </div>
    </div>
    <br />
</asp:Content>
