<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminPendingRequest.aspx.cs" Inherits="OnlineMedicineDonationToNgo.AdminCheckTransaction" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });

    </script>
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <div class="container-fluid">
        <div class="row">
            <div class="col">

                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <h4> All Pending</h4>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineMedicineDonationToNgoConnectionString %>" SelectCommand="SELECT * FROM [ngo_request_medicine_table]"></asp:SqlDataSource>
                                <asp:GridView class="table thead-light table-bordered" ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="request_id" DataSourceID="SqlDataSource2">
                                    <Columns>
                                        <asp:BoundField DataField="content_name" HeaderText="Content Name" SortExpression="content_name" />
                                        <asp:BoundField DataField="quantity" HeaderText="Quantity" SortExpression="quantity" />
                                        <asp:BoundField DataField="issue_date" HeaderText="Issue Date" SortExpression="issue_date" />
                                        <asp:BoundField DataField="expiry_date" HeaderText="Expiry Date" SortExpression="expiry_date" />
                                        <asp:BoundField DataField="location" HeaderText="Location" SortExpression="location" />
                                        <asp:BoundField DataField="type_of_medicine" HeaderText="Type of Medicine" SortExpression="type_of_medicine" />
                                        <asp:BoundField DataField="ngo_name" HeaderText="NGO Name" SortExpression="ngo_name" />
                                        <asp:BoundField DataField="ngo_email_id" HeaderText="NGO Email ID" SortExpression="ngo_email_id" />
                                        <asp:BoundField DataField="request_id" HeaderText="Request ID" ReadOnly="True" SortExpression="request_id" />
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
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
