<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Client/ClientMaster.Master" AutoEventWireup="true" CodeBehind="BookingPage.aspx.cs" Inherits="ContainerManagementSystem.Pages.Client.BookingPage1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="../../Script/css/bootstrap-datetimepicker.min.css" rel="stylesheet" />
    <script src="../../Script/js/bootstrap-datetimepicker.js"></script>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="container" runat="server">
    <div class="form-group">
        <div class="row">
            <div class="col-2">
                <div class="col-2">
                    <label for="exampleFormControlSelect1">Weight</label>
                </div>
                <div class="col-12">
                    <asp:TextBox ID="weight" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:Button runat="server" ID="Book" CssClass="col-sm-12 btn btn-primary" OnClick="Book_Click" Text="Book Container" />
                </div>
            </div>
            <div class="col-9">
                <asp:Repeater ID="rptTable" runat="server">
                    <HeaderTemplate>
                        <table class="table table-striped">
                            <thead>
                                <tr>
                                    <th>Container Code</th>
                                    <th>Departure Country</th>
                                    <th>Arrival Country</th>
                                    <th>Departure Date</th>
                                </tr>
                            </thead>
                            <tbody>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("container_number") %></td>
                            <td><%# Eval("departure_port") %></td>
                            <td><%# Eval("arrival_port") %></td>
                            <td><%# Eval("departure_date") %></td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </tbody>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
