<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="NgoDonationReceive.aspx.cs" Inherits="OnlineMedicineDonationToNgo.NgoDonationReceive" %>
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
                                <h4>Donated</h4>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:OnlineMedicineDonationToNgoConnectionString %>" SelectCommand="SELECT * FROM [donated_medicine_table] WHERE ([donate_to] = @donate_to)">
                                    <SelectParameters>
                                        <asp:SessionParameter Name="donate_to" SessionField="ngo_name" Type="String" />
                                    </SelectParameters>
                                </asp:SqlDataSource>

                                <asp:GridView class="table thead-dark table-bordered" ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2">
                                    <Columns>
                                        <asp:BoundField DataField="request_id" HeaderText="Request ID" SortExpression="request_id" />
                                        <asp:BoundField DataField="content_name" HeaderText="Content Name" SortExpression="content_name" />
                                        <asp:BoundField DataField="brand_name" HeaderText="Brand Name" SortExpression="brand_name" />
                                        <asp:BoundField DataField="quantity" HeaderText="Quantity" SortExpression="quantity" />
                                        <asp:BoundField DataField="date_of_manufactured" HeaderText="Date of Manufactured" SortExpression="date_of_manufactured" />
                                        <asp:BoundField DataField="expiry_date" HeaderText="Expiry Date" SortExpression="expiry_date" />
                                        <asp:BoundField DataField="type_of_medicine" HeaderText="Type of medicine" SortExpression="type_of_medicine" />
                                        <asp:BoundField DataField="donor_firstname" HeaderText="Donar Firstname" SortExpression="donor_firstname" />
                                        <asp:BoundField DataField="donor_surname" HeaderText="Donar Surname" SortExpression="donor_surname" />
                                        <asp:BoundField DataField="donate_to" HeaderText="Donate To" SortExpression="donate_to" />
                                        <asp:BoundField DataField="todays_date" HeaderText="Donation Date" SortExpression="todays_date" />
                                        <asp:BoundField DataField="donor_email_id" HeaderText="donor_email_id" SortExpression="donor_email_id" />
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
