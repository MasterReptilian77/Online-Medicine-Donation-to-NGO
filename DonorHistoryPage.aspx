<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="DonorHistoryPage.aspx.cs" Inherits="OnlineMedicineDonationToNgo.DonorHistoryPage" %>
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
            <div class="col">
                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <h4>Donation History</h4>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>

                        <br />
                        <div class="row">
                            <div class="col">
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineMedicineDonationToNgoConnectionString %>" SelectCommand="SELECT * FROM [donated_medicine_table] WHERE ([donor_email_id] = @donor_email_id)">
                                    <SelectParameters>
                                        <asp:SessionParameter Name="donor_email_id" SessionField="donor_email_id" Type="String" />
                                    </SelectParameters>
                                </asp:SqlDataSource>
                                <asp:GridView class="table thead-dark table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                                    <Columns>
                                        <asp:BoundField DataField="content_name" HeaderText="Content Name" SortExpression="content_name" />
                                        <asp:BoundField DataField="brand_name" HeaderText="Brand Name" SortExpression="brand_name" />
                                        <asp:BoundField DataField="date_of_manufactured" HeaderText="Date of Manufactured" SortExpression="date_of_manufactured" />
                                        <asp:BoundField DataField="expiry_date" HeaderText="Expiry Date" SortExpression="expiry_date" />
                                        <asp:BoundField DataField="quantity" HeaderText="Quantity" SortExpression="quantity" />
                                        <asp:BoundField DataField="type_of_medicine" HeaderText="Type of Medicine" SortExpression="type_of_medicine" />
                                        <asp:BoundField DataField="donor_firstname" HeaderText="Donor Firstname" SortExpression="donor_firstname" />
                                        <asp:BoundField DataField="donor_surname" HeaderText="Donor Surname" SortExpression="donor_surname" />
                                        <asp:BoundField DataField="donate_to" HeaderText="Donate To" SortExpression="donate_to" />
                                        <asp:BoundField DataField="todays_date" HeaderText="Donation Date" SortExpression="todays_date" />
                                        <asp:BoundField DataField="donor_email_id" HeaderText="Donor Email ID" SortExpression="donor_email_id" />
                                        <asp:BoundField DataField="request_id" HeaderText="Request ID" SortExpression="request_id" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>


                    </div>
                </div>
                <br />
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
</asp:Content>
