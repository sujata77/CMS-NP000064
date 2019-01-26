<%@ Page Title="" Language="C#" MasterPageFile="~/PublicMaster.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="ContainerManagementSystem.Pages.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Login
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="container" runat="server">
    <asp:Literal ID="msg" runat="server"></asp:Literal>
    <div class="row" style="margin: 130px 150px;;">
        <div class="col-8 card">
            <h5>Login</h5>
            <div class="form-group">
                <div class="row">
                    
                    <div class="col-4">
                        <label for="exampleInputEmail1">Username</label>
                    </div>
                    <div class="col-7">
                       
                            <asp:TextBox runat="server" ID="usernameTxt" placeholder="Username" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="usernameTxt" Text="Username is Required" ErrorMessage="Password is Required"></asp:RequiredFieldValidator>
                        
    </div>
    </div>
            </div>
            <div class="form-group">
                <div class="row">
                    <div class="col-4">
                        <label for="exampleInputPassword1">Password</label>
                    </div>
                    <div class="col-7">
                       
                            <asp:TextBox runat="server" ID="passwordTxt" placeholder="Password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="passwordTxt" Text="Password is Required" ErrorMessage="Password is Required"></asp:RequiredFieldValidator>
                        
                    </div>
                </div>
            </div>
            <asp:Button ID="LoginButton" CssClass="btn btn-primary" OnClick="LoginButton_Click" Text="Login" runat="server"  style="margin-bottom:8px;" />
        </div>

    </div>

</asp:Content>
