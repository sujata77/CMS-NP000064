<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="UsersPage.aspx.cs" Inherits="ContainerManagementSystem.Pages.Admin.UsersPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Users
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="container" runat="server">
     <div class="row">
                <div class="col-10">

                    <asp:Repeater ID="rptTable" runat="server">
                        <HeaderTemplate>
                            <table class="table">
                                <thead>
                                    <tr>
                                        <th>Name</th>
                                        <th>Address</th>
                                        <th>Email</th>
                                        <th>Contact</th>
                                        <th>Username</th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("name") %></td>
                                <td><%# Eval("address") %></td>
                                <td><%# Eval("email") %></td>
                                <td><%# Eval("contact_number") %></td>
                                <td><%# Eval("username") %></td>
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
