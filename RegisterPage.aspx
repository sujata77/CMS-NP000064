<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="ContainerManagementSystem.Pages.RegisterPage" MasterPageFile="~/PublicMaster.Master" %>


<asp:Content ID="Container" ContentPlaceHolderID="container" runat="server">
    <div class="row">
        <div class="col-sm-8 card" style="margin: 50px auto;">

     
                <div style="padding: 8px;">Fill the form to register </div>
                <div>
                    <div class="form-group col-sm-12">
                        <asp:TextBox runat="server" ID="nameTxt" placeholder="Full Name" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="nameRequired" runat="server" ControlToValidate="usernameTxt" Text="Name Required" ErrorMessage="Username Required"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group col-sm-12">
                        <asp:TextBox runat="server" ID="addressTxt" placeholder="Address" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Email" runat="server" ControlToValidate="addressTxt" Text="Address is Required" ErrorMessage="Address is Required"></asp:RequiredFieldValidator>

                    </div>
                    <div class="form-group col-sm-12">
                        <asp:TextBox runat="server" ID="emailTxt" placeholder="Email" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="contact" runat="server" ControlToValidate="emailTxt" Text="Email is Required" ErrorMessage="Email is Required"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="Regularexpressionvalidator2" runat="server" ControlToValidate="emailTxt" ErrorMessage="Enter Correct Email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>

                    </div>
                    <div class="form-group col-sm-12">
                        <asp:TextBox runat="server" ID="contactTxt" placeholder="Contact" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="contactTxt" Text="Contact is Required" ErrorMessage="Address is Required"></asp:RequiredFieldValidator>

                    </div>
                    <div class="form-group col-sm-12">
                        <asp:TextBox runat="server" ID="usernameTxt" placeholder="Username" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="usernameTxt" Text="Username is Required" ErrorMessage="Address is Required"></asp:RequiredFieldValidator>

                    </div>
                    <div class="form-group col-sm-12">
                        <asp:TextBox runat="server" ID="passwordTxt" placeholder="Password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordValidator" runat="server" ControlToValidate="passwordTxt" Text="Password is Required" ErrorMessage="Password is Required"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group col-sm-12">
                        <asp:TextBox runat="server" ID="repasswordTxt" placeholder="Password" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="Reenter" runat="server" ControlToValidate="repasswordTxt" Text="Re-Enter Password Required" ErrorMessage="Re-Enter Password Required"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="PasswordCompare" CssClass="text-danger col-sm-12" runat="server" ControlToCompare="passwordTxt" ControlToValidate="repasswordTxt" Text="Password Not Matched" ErrorMessage="Password Not Matched"></asp:CompareValidator>
                    </div>

                    <div class="form-group col-12">
                        <asp:Button ID="Register" runat="server" Text="Register" CssClass="btn btn-success form-control" OnClick="Register_Click" />
                    </div>
                    <asp:Literal ID="ltrText" runat="server"></asp:Literal>
                </div>
            </div>
        </div>
    </div>
     
</asp:Content>


