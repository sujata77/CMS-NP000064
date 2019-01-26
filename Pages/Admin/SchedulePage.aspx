<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Admin/AdminMaster.Master" AutoEventWireup="true" CodeBehind="SchedulePage.aspx.cs" Inherits="ContainerManagementSystem.Pages.Admin.SchedulePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Schedule
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="../../Script/css/bootstrap-datetimepicker.min.css" rel="stylesheet" />
    <script src="../../Script/js/bootstrap-datetimepicker.js"></script>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="container" runat="server">
    <div class="row">
        <div class="col-12">
             <div class="form-group">
        <div class="row">
            <div class="col-2">
                <label for="exampleFormControlSelect1">Departure Country</label>
            </div>
            <div class="col-4">
                <asp:DropDownList runat="server" ID="DepartureCountry" CssClass="form-control" OnTextChanged="DepartureCountry_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
        </div>
    </div>
     <div class="form-group">
        <div class="row">
            <div class="col-2">
                <label for="exampleFormControlSelect1">Arrival Country</label>
            </div>
            <div class="col-4">
                <asp:DropDownList runat="server" ID="ArrivalCountry" CssClass="form-control">
                </asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="row">
            <div class="col-2">
                <label for="exampleFormControlSelect1">Container</label>
            </div>
            <div class="col-4">
                <asp:DropDownList runat="server" ID="Container" CssClass="form-control">
                </asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="row">
            <div class="col-2">
                <label for="exampleFormControlSelect1">Capacity</label>
            </div>
            <div class="col-4">
                <asp:TextBox ID="capacity" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
        </div>
    </div>
    <div class="form-group">
        <div class="row">
            <div class="col-2">
                <label for="date">Departure Date</label>
            </div>
            <div class="col-5">
                <div class="input-group date form_date" data-date="" data-date-format="dd MM yyyy" data-link-field="dtp_input2" data-link-format="yyyy-mm-dd">
                    <asp:TextBox runat="server" ID="departureDate" class="form-control datetimepicker" name="date" />
                    <span class="input-group-addon"><span class="glyphicon glyphicon-remove"></span></span>
                    <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="departureDate" Text="Date Required" CssClass="text-danger" runat="server" ErrorMessage="Date Required"></asp:RequiredFieldValidator>
                </div>
            </div>
        </div>
    </div>
    <div class="form-group">
        <asp:Button runat="server" ID="Book" CssClass="btn btn-primary" Text="Add Schedule" OnClick="Book_Click" />
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
                                <th>Container Code</th>
                                <th>Departure Country</th>
                                <th>Arrival Country</th>
                                <th>Departure Date</th>
                                <th>Capacity</th>
                                <th>Shipping Status</th>
                                <th>Received Date</th>
                                <th>Action</th>
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
                        <td><%# Eval("capacity") %></td>
                        <td><%# Eval("shipping_status") %></td>
                        <td><%# int.Parse(Eval("shipping_status_id").ToString()) == 1 ? "<a href='SchedulePage.aspx?id="+ Eval("id")+"&&container-id="+ Eval("container_id")+"' class='btn btn-primary'>Change Shipping Status</a>":"Received Already"%>
                        <td><%# Eval("arrived_date").ToString() == "" ? "Not Received Yet":Eval("arrived_date")%>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </tbody>
                        </table>
                </FooterTemplate>
            </asp:Repeater>

        </div>
    </div>
    <script type="text/javascript">
        $(function () {
            $('.datetimepicker').datetimepicker({
                format: 'yyyy-mm-dd HH:mm:ss'
            });
        });
    </script>
</asp:Content>
