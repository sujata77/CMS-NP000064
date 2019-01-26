<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="BookingPage.aspx.cs" Inherits="ContainerManagementSystem.Pages.Admin.BookingPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="container" runat="server">
    <div class="row">
        <div class="col-12">
             <asp:Repeater ID="rptTable" runat="server">
                <HeaderTemplate>
                    <table class="table">
                        <thead>
                            <tr>
                                <th>Container Code</th>
                                <th>Departure Country</th>
                                <th>Name</th>
                                <th>Email</th>
                                <th>Contact</th>
                                <th>Departure Date</th>
                                <th>Approval Status</th>

                            </tr>
                        </thead>
                        <tbody>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("container_number") %></td>
                        <td><%# Eval("departure_port") %></td>
                        <td><%# Eval("name") %></td>
                        <td><%# Eval("email") %></td>
                        <td><%# Eval("contact_number") %></td>
                        <td><%# Eval("departure_date") %></td>
                        <td><%# int.Parse(Eval("approval_status").ToString()) == 0 ? "<a href='BookingPage.aspx?id="+ Eval("id")+"' class='btn btn-primary'>Approve</a>" :"Approved" %>
                            
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                        </table>
                </FooterTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
