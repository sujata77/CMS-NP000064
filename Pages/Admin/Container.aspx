<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="ContainerManagementSystem.Pages.Admin.Container" MasterPageFile="~/Pages/Admin/AdminMaster.Master" %>

<asp:Content ContentPlaceHolderID="title" runat="server">
    Container
</asp:Content>
<asp:Content ContentPlaceHolderID="container" runat="server">
    <div class="row">
        <div class="col-sm-12">
            <h1 class="text-center">Add Container</h1>
            <asp:Literal runat="server" ID="information"></asp:Literal>
            <div class="row">
                <div class="col-4">
                    <div class="form-group">
                        <div class="row">
                            <div class="col-6" style="padding-top: 8px">
                                <label for="title">Container Number</label>
                            </div>
                            <div class="col-6">
                                <asp:TextBox ID="containerNumberTxt" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="containerNumberTxt" Text="Title Required" CssClass="text-danger" runat="server" ErrorMessage="Title Required"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-4">
                    <div class="row">
                        <div class="col-3" style="padding-top: 8px">
                            <label for="title">Country</label>
                        </div>
                        <div class="col-9">
                            <asp:DropDownList ID="Country" runat="server" CssClass="form-control"></asp:DropDownList>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="Country" Text="Title Required" CssClass="text-danger" runat="server" ErrorMessage="Title Required"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div class="col-4">
                    <div class="form-group">
                        <asp:Button ID="submit" runat="server" Text="Add Container" CssClass="btn btn-primary" OnClick="submit_Click" />
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-10">
                    <asp:Repeater ID="rptTable" runat="server">
                        <HeaderTemplate>
                            <table class="table">
                                <thead>
                                    <tr>
                                        <th>Container Number</th>
                                        <th>Country</th>
                                        <th>Status</th>
                                        <th>Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("container_number") %></td>
                                <td><%# Eval("country") %></td>
                                <td><%# int.Parse(Eval("status").ToString()) == 0 ? "Avialabel" : "Booked" %></td>
                                <td><a href="Container.aspx?id=<%# Eval("id") %>" class="btn btn-primary">Edit</a></td>
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
    </div>
</asp:Content>
