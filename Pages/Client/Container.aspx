<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Client/ClientMaster.Master" AutoEventWireup="true" CodeBehind="Container.aspx.cs" Inherits="ContainerManagementSystem.Pages.Client.Container" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="container" runat="server">
    <asp:Literal ID="msg" runat="server"></asp:Literal>
    <div class="row">
        <div class="col-10">
            <h5>Container Booking Status</h5>
            <asp:Repeater ID="rptTable" runat="server">
                <HeaderTemplate>
                    <table class="table table-striped">
                        <thead>
                            <tr>
                                <th>Container Code</th>
                                <th>Departure Country</th>
                                <th>Arrival Country</th>
                                <th>Departure Date</th>
                                <th>Approval Status</th>
                                <th>Receivied Status</th>
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
                        <td><%# int.Parse(Eval("approval_status").ToString()) == 0 ? "Not Approved" : "Approved" %></td>
                        <td><%# int.Parse(Eval("booking_shipping_status_id").ToString()) == 1 ? "<a href='Container.aspx?id="+ Eval("id")+"' class='btn btn-primary'>Pending</a>" :"Received" %>
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
