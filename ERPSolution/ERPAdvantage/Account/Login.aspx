<%@ Page Title="Log In" Language="C#" Inherits="ERPAdvantage.Account.Login"  MasterPageFile="~/Site.master" AutoEventWireup="True"
    CodeBehind="Login.aspx.cs" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Log In
    </h2>
    <p>
        Please enter your username and password.
        <asp:HyperLink ID="RegisterHyperLink" runat="server" EnableViewState="false">Register</asp:HyperLink> if you don't have an account.
    </p>
    <asp:Login ID="LoginUser" runat="server" EnableViewState="true" RenderOuterTable="false" >
        <LayoutTemplate>
            <span class="failureNotification">
                <asp:Literal ID="FailureText" runat="server"></asp:Literal>
            </span>
            <asp:ValidationSummary ID="LoginUserValidationSummary" runat="server" CssClass="failureNotification" 
                 ValidationGroup="LoginUserValidationGroup"/>
            <div class="accountInfo">
                <fieldset class="login">
                    <legend>Account Information</legend>
                    <p>
                     <asp:Label ID="lblcompanyName" runat="server" AssociatedControlID="txtcompany">Company:</asp:Label>
                       <asp:TextBox ID="txtcompany" runat="server" CssClass="textEntry">Abans Electricals PLC</asp:TextBox>
                    </p>
                    
                    <p>
                     <asp:Label ID="lblBranch" runat="server" AssociatedControlID="ddlBranch">Branch:</asp:Label>
                        <asp:DropDownList ID="ddlBranch" runat="server" AutoPostBack="True" 
                            onselectedindexchanged="ddlBranch_SelectedIndexChanged"> 
                                              
                        </asp:DropDownList>
                     </p>

                    <p>
                     <asp:Label ID="lblbranchname" runat="server" AssociatedControlID="txtBranchName">Branch Name:</asp:Label>
                     <asp:TextBox ID="txtBranchName" runat="server" CssClass="textEntry"></asp:TextBox>
                    </p>
                    <p>
                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Username:</asp:Label>
                        <asp:TextBox ID="UserName" runat="server" CssClass="textEntry"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" 
                             CssClass="failureNotification" ErrorMessage="User Name is required." ToolTip="User Name is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                        <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" 
                             CssClass="failureNotification" ErrorMessage="Password is required." ToolTip="Password is required." 
                             ValidationGroup="LoginUserValidationGroup">*</asp:RequiredFieldValidator>
                    </p>
                    <p>
                       <tr>
                       <td>
                        <asp:CheckBox ID="RememberMe" runat="server"/>
                        <asp:Label ID="RememberMeLabel" runat="server" AssociatedControlID="RememberMe" CssClass="inline">Keep me logged in</asp:Label>
                        </td>
                        <td>
                        
                            <asp:HyperLink ID="hlChapass" runat="server" ForeColor="#3333FF" 
                                NavigateUrl="~/Account/ChangePassword.aspx">Change Password</asp:HyperLink>
                        </td>
                        </tr>
                    </p>
                   
                </fieldset>
                <p class="submitButton">
                    <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" 
                        ValidationGroup="LoginUserValidationGroup" Height="26px"/>
                </p>
            </div>
        </LayoutTemplate>
    </asp:Login>
</asp:Content>


