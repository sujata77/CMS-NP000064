<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Client/ClientMaster.Master" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="SearchContainerPage.aspx.cs" Inherits="ContainerManagementSystem.Pages.Client.BookingPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Booking
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="../../Script/css/bootstrap-datetimepicker.min.css" rel="stylesheet" />
    <script src="../../Script/js/bootstrap-datetimepicker.js"></script>
    <style>
        .input-group {
        
            border:0px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="container" runat="server">
    <div class="row">
        <div class="col-12">
            <asp:Literal ID="Info" runat="server"></asp:Literal>
            <asp:Literal runat="server" ID="information"></asp:Literal>
            <div class="row">
                <div class="col-12 card">
                    <h4 class="text-center">Search Containers</h4>
                    <div class="row">
                        <div class="col-4">
                            <div class="col-12" style="padding-top: 8px">
                                <label for="title">Country</label>
                            </div>
                            <div class="col-12">
                                <asp:DropDownList ID="Country" runat="server" CssClass="form-control"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="Country" Text="Title Required" CssClass="text-danger" runat="server" ErrorMessage="Title Required"></asp:RequiredFieldValidator>
                            </div>
                        </div>

                        <div class="col-4">
                            <div class="form-group">
                                <div class="row">
                                    <div class="col-12">
                                        <label for="date">Departure Date</label>
                                    </div>
                                    <div class="col-12">
                                        <div class="input-group form-control date form_date" data-date="" data-date-format="dd MM yyyy" data-link-field="dtp_input2" data-link-format="yyyy-mm-dd">
                                            <asp:TextBox runat="server" ID="departureDate" class="form-control datetimepicker" name="date" />
                                            <span class="input-group-addon"><span class="glyphicon glyphicon-remove"></span></span>
                                            <span class="input-group-addon"><span class="glyphicon glyphicon-calendar"></span></span>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" ControlToValidate="departureDate" Text="Date Required" CssClass="text-danger" runat="server" ErrorMessage="Date Required"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-4">
                            <div class="col-3" style="padding-top: 18px">
                               
                            </div>
                            <div class="col-4" style="margin-top:8px">
                                <div class="col-12">
                                       
                                    </div>
                                <div class="col-12">
                                 <asp:Button ID="SearchContainer" runat="server" Text="Search" CssClass="btn btn-primary" style="padding-top: 8px" OnClick="SearchContainer_Click" />

                                </div>
                            </div>
                        </div>
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
                                        <th>Departure Date</th>
                                         <th>Container Code</th>
                                        <th>Departure Country</th>
                                        <th>Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("departure_date") %></td>
                                <td><%# Eval("container_number") %></td>
                                <td><%# Eval("departure_port") %></td>
                                <td><a href="BookingPage.aspx?schedule_id=<%# Eval("id") %>" class="btn btn-primary">Book Container</a> </td>

                                <td></td>
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
    <%-- <script type="text/javascript">
        $(function () {
            $('.datetimepicker').datetimepicker({
                format: 'yyyy-mm-dd HH:mm:ss'
            });
        });
    </script>--%>
</asp:Content>
